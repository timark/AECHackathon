/////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Autodesk, Inc. All rights reserved
// Written by Philippe Leefsma 2014 - ADN/Developer Technical Services
//
// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted,
// provided that the above copyright notice appears in all copies and
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting
// documentation.
//
// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS.
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK, INC.
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.
/////////////////////////////////////////////////////////////////////////////////
var defaultUrn = 'dXJuOmFkc2sub2JqZWN0czpvcy5vYmplY3Q6YmtfbWVkL0NsaW5pY19Cb2lsZXJSb29tLnJ2dA==';
/*
$(document).ready(function () {
    var tokenurl = 'http://' + window.location.host + '/api/token';
    var config = {
        environment : 'AutodeskProduction'
		//environment : 'AutodeskStaging'
    };

    // Instantiate viewer factory
    var viewerFactory = new Autodesk.ADN.Toolkit.Viewer.AdnViewerFactory(
        tokenurl,
        config);

    // Allows different urn to be passed as url parameter
    var paramUrn = Autodesk.Viewing.Private.getParameterByName('urn');
    var urn = (paramUrn !== '' ? paramUrn : defaultUrn);

    viewerFactory.getViewablePath (urn,
        function(pathInfoCollection) {
            var viewerConfig = {
                viewerType: 'GuiViewer3D'
            };

            var viewer = viewerFactory.createViewer(
                $('#viewerDiv')[0],
                viewerConfig);

            viewer.load(pathInfoCollection.path3d[0].path);
        },
        onError);

});

function onError(error) {
    console.log('Error: ' + error);

};
*/




var viewer;
$(document).ready(function () {
    ////

    var getToken = function () {
        /*
        var xhr = new XMLHttpRequest();
        xhr.open("GET", 'http://' + window.location.host + '/api/token', false);
        xhr.send(null);
        console.log("test " + xhr.responseText);
        */
        var jso = JSON.parse(auth_script);
        return jso.access_token;
    }

    function initializeViewer(containerId, documentId, role) {
        var viewerContainer = document.getElementById(containerId);
        var _viewer = new Autodesk.Viewing.Private.GuiViewer3D(
                viewerContainer);
        _viewer.start();

        Autodesk.Viewing.Document.load(documentId,
                function (document) {
                    var rootItem = document.getRootItem();
                    var geometryItems = Autodesk.Viewing.Document.getSubItemsWithProperties(
                            rootItem,
                            { 'type': 'geometry', 'role': role },
                            true);

                    _viewer.load(document.getViewablePath(geometryItems[0]));
                },

                function (msg) {
                    console.log("Error loading document: " + msg);
                }
        );
        return _viewer;
    }

    function initialize() {
        var options = {
            env: "AutodeskProduction",
            getAccessToken: getToken,
            refreshToken: getToken
        };
        console.log("test " + options.getAccessToken);
        var paramUrn = Autodesk.Viewing.Private.getParameterByName('urn');
        var urn = (paramUrn !== '' ? paramUrn : defaultUrn);
        urn = "https://developer.api.autodesk.com/viewingservice/v1/" + urn;
        Autodesk.Viewing.Initializer(options, function () {
            viewer = initializeViewer('viewerDiv', urn, '3d');
        });
    }
    initialize();
    setInterval(loop, 500);

});

var prevSelectedId, selectedId;
function loop() {
    select = viewer.getSelection();
    if (select[0] !== prevSelectedId) {
        console.log(select[0]);
        currentSelection();
        prevSelectedId = select[0];
    }
    
}
