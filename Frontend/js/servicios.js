function httpGet() {
    var xmlHttp = new XMLHttpRequest();
    xmlHttp.open("GET", url, false);
    xmlHttp.send(null);
    return JSON.parse(xmlHttp.responseText);
}

function httpGetById(id) {
    var xmlHttp = new XMLHttpRequest();
    xmlHttp.open("GET", url + `/${id}`, false);
    xmlHttp.send(null);
    return JSON.parse(xmlHttp.responseText);
}

function httpDelete(id) {
    var xmlHttp = new XMLHttpRequest();
    xmlHttp.open("DELETE", url + `/${id}`, false);
    xmlHttp.setRequestHeader('Access-Control-Allow-Origin', '*');
    xmlHttp.send(null);
}

function httpPut(id, object) {
    var xmlHttp = new XMLHttpRequest();
    var json = JSON.stringify(object);
    xmlHttp.open("PUT", url + `/${id}`, false);
    xmlHttp.setRequestHeader('Content-type', 'application/json; charset=utf-8');
    xmlHttp.send(json);
}

function httpPost(object) {
    var xmlHttp = new XMLHttpRequest();
    var json = JSON.stringify(object);
    xmlHttp.open("POST", url, false);
    xmlHttp.setRequestHeader('Content-type', 'application/json; charset=utf-8');
    xmlHttp.send(json);
}

var url = 'http://localhost:57661/api/main';
