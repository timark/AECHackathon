
// Misc-Gmaps.js
// ====================================================================
// This file should not be included in your project.
// This is just a sample how to initialize plugins or components.
//
// - ThemeOn.net -



$(document).ready(function() {



	var markerMap = new GMaps({
		el: '#demo-type-map',
		lat: 52.937956,
		lng: -1.1857273,
		mapTypeControlOptions: {
			mapTypeIds : ["hybrid", "roadmap", "satellite", "terrain", "osm"]
		}
	});
	
		markerMap.addMapType("osm", {
		getTileUrl: function(coord, zoom) {
			return "http://tile.openstreetmap.org/" + zoom + "/" + coord.x + "/" + coord.y + ".png";
		},
		tileSize: new google.maps.Size(256, 256),
		name: "OpenStreetMap",
		maxZoom: 18
	});
	
	
	markerMap.addMarker({
		lat: 52.937956,
		lng: -1.1857273,
		title: 'Location',
		click: function(e) {
			$.niftyNoty({
				type: "info",
				icon: "fa fa-info",
				message: "Campus 1",
				container: 'floating',
				timer: 3500
			});
		},
		infoWindow: {
			 content: '<div>activePLAN Site 1</div>'
		}
	});
	
	markerMap.addMarker({
		lat: 52.935956,
		lng: -1.1897273,
		title: 'Location',
		click: function(e) {
			$.niftyNoty({
				type: "info",
				icon: "fa fa-info",
				message: "Campus 2",
				container: 'floating',
				timer: 3500
			});
		},
		infoWindow: {
			 content: '<div>activePLAN Site 2</div>'
		}
	});
	
	markerMap.setMapTypeId("osm");

});
