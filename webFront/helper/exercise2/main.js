let stations = [];

function retrieveAllContracts() {
    var targetUrl = "https://api.jcdecaux.com/vls/v3/contracts?apiKey=" + document.getElementById("apiKey").value;
    var requestType = "GET";

    var caller = new XMLHttpRequest();
    caller.open(requestType, targetUrl, true);
    // The header set below limits the elements we are OK to retrieve from the server.
    caller.setRequestHeader ("Accept", "application/json");
    // onload shall contain the function that will be called when the call is finished.
    caller.onload=contractsRetrieved;

    caller.send();
}

function contractsRetrieved() {
    // Let's parse the response:
    var response = JSON.parse(this.responseText);
    var options = '';
    response.forEach(c => {
        options += '<option value="' + c.name + '" />';
    });

    document.getElementById('contracts').innerHTML = options;

}

function retrieveContractStations() {
    var targetUrl = "https://api.jcdecaux.com/vls/v3/stations?contract=" + document.getElementById("contractChoice").value + "&apiKey=" + document.getElementById("apiKey").value;
    var requestType = "GET";

    var caller = new XMLHttpRequest();
    caller.open(requestType, targetUrl, true);
    // The header set below limits the elements we are OK to retrieve from the server.
    caller.setRequestHeader("Accept", "application/json");
    // onload shall contain the function that will be called when the call is finished.
    caller.onload = contractStationsRetrieved;

    caller.send();
}

function contractStationsRetrieved() {
    // Let's parse the response:
    var response = JSON.parse(this.responseText);
    stations = response;
    console.log(response);

}

function getDistanceFrom2GpsCoordinates(lat1, lon1, lat2, lon2) {
   // Radius of the earth in km
   var earthRadius = 6371;
   var dLat = deg2rad(lat2 - lat1);
   var dLon = deg2rad(lon2 - lon1);
   var a =
       Math.sin(dLat / 2) * Math.sin(dLat / 2) +
       Math.cos(deg2rad(lat1)) * Math.cos(deg2rad(lat2)) *
       Math.sin(dLon / 2) * Math.sin(dLon / 2)
       ;
   var c = 2 * Math.atan2(Math.sqrt(a), Math.sqrt(1 - a));
   var d = earthRadius * c; // Distance in km
   return d;
}

function deg2rad(deg) {
   return deg * (Math.PI / 180)
}

function getClosestStation() {
    let lat = document.getElementById("latitude").value;
    let long = document.getElementById("longitude").value;
    var station = stations[0];
    var closestDistance = getDistanceFrom2GpsCoordinates(lat, long, station.position.latitude, station.position.longitude);
    stations.forEach(s => {
        var newDistance = getDistanceFrom2GpsCoordinates(lat, long, s.position.latitude, s.position.longitude);
        if (newDistance < closestDistance) {
            station = s;
            closestDistance = newDistance;
        }
    });
    document.getElementById('closest-station').innerHTML = station.name;
}