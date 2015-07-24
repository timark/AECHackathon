
// UI-Panels.js
// ====================================================================
// ====================================================================
// - ThemeOn.net -


 $(document).ready(function() {
	// Turn your default html checkbox inputs into beautiful ios 7 style switches.
	// =================================================================
	new Switchery(document.getElementById('demo-panel-w-switch'));


	// Bubble help
	// =================================================================
	$('#demo-help').tooltip({
		html:true,
		placement:'top',
		title:"<h4>Information</h4><p style='width:150px'>This is an information bubble to help the user.</p>"
	}).on('click', function(e){
		e.preventDefault();
		e.stopPropagation();
	});


	// Loading overlay.
	// =================================================================
	$('.demo-panel-ref-btn').niftyOverlay().on('click', function(){
		var $el = $(this), relTime;
		$el.niftyOverlay('show');
		relTime = setInterval(function(){
			$el.niftyOverlay('hide');
			clearInterval(relTime);
		},2000);
	});


	// Auto close alers.
	// =================================================================
	$('#demo-panel-alert').on('click', function(){
		$.niftyNoty({
			type: 'primary',
			container : '#demo-panel-w-alert',
			html : '<strong>Well done!</strong> You successfully read this important alert message.',
			focus: false,
			timer : 2000
		});
	});

	// Sticky alerts
	// =================================================================
	$('#demo-panel-alert2').on('click', function(){
		$.niftyNoty({
			type: 'warning',
			container : '#demo-panel-w-alert',
			html : '<strong>Well done!</strong> You successfully read this important alert message.',
			focus: false
		});
	});




 });
