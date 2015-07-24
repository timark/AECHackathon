// JavaScript Document
dbVersion = 13
dbName = "activePLAN"
var apProtocol = ''
//var apProtocol = 'http://'
var apHost = '';
//var apHost = 'localhost:8090'

var apResourceRoot = '/Register/'


function guid() {
  function s4() {
    return Math.floor((1 + Math.random()) * 0x10000)
      .toString(16)
      .substring(1);
  }
  return s4() + s4() + '-' + s4() + '-' + s4() + '-' +
    s4() + '-' + s4() + s4() + s4();
}

function logOut()
{
	localStorage.removeItem("IDUser");
	getSection("/login")
}

function lockScreen()
{
	localStorage.setItem("lockScreen", window.location);
	getSection("/lock-screen")
}


function recordbug(id) {
    var t = new Date()
    var url = "../../forms/bug.html?t=" + t.getTime()
    $.ajax({
        url: url
    }).done(function (data) {
        bootbox.dialog({
            title: "submit bug for " + id,
            message: data,
            buttons: {
                confirm: {
                    label: "Close"
                }
            }
        });
    });
}

function sugestions(id)
{
    var t = new Date()
    var url = "../../help/" + id + ".html?t=" + t.getTime()
    $.ajax({
        url: url
    }).done(function (data ) {
       bootbox.dialog({
        title: "Help for " + id,
        message: data,
        buttons: {
            confirm: {
                label: "Close"
            }
        }
    });
    });
}

function getSection(obj)
{
	
	//$('#apForm').attr('enctype','')	
	//$('#apForm').attr('action',obj + '.html')	
	//$('#apForm').attr('action',obj + '.aspx')		  
	//$('#apForm').submit()
	//alert('failed')
	//document.apForm.action = obj + '.html'
	//document.apForm.submit()
	$(location).attr('href',obj + '.html');
	//alert('failed')
}

function pager(act, callbackfunction)
{
	if (act == 'first') {
		currentPage = 1
		}
	if (act == 'previous') {
		if (currentPage > 1 ){currentPage -= 1}
		}
	if (act == 'next') { 
		if (currentPage != totalPages ){currentPage += 1}
		}
	if (act == 'last') {
		if (currentPage != totalPages ){currentPage = totalPages}
		}
	
	//$("#pageNo").val(currentPage)
	
	callbackfunction.call()	
}



function logout() {
	getSection ("index")
}

function convertFromXMLtext(textStr)
{
	 textStr = textStr.replace('&','&')
	 
	 return textStr;
}

var transTime = "0.5s"


function setPager(returnFunc )
{	
		$(function() {		
			$( "#pager_first" )		
			.bind("click", function(event) {
			event.preventDefault();
			pager('first',function(){returnFunc()})
		})		
			.button({
				label: "first",
				text: false,
				icons: {primary: "ui-icon-seek-start"}
			})
		});		

		$(function() {		
			$( "#pager_previous" )		
			.bind("click", function(event) {
			event.preventDefault();
			pager('previous',function(){returnFunc()})
		})		
			.button({
				label: "previous",
				text: false,
				icons: {primary: "ui-icon-seek-prev"}
			})
		});

		$(function() {		
			$( "#pager_next" )		
			.bind("click", function(event) {
			event.preventDefault();
			pager('next',function(){returnFunc()})
		})		
			.button({
				label: "next",
				text: false,
				icons: {primary: "ui-icon-seek-next"}
			})
		});

		$(function() {		
			$( "#pager_last" )		
			.bind("click", function(event) {
			event.preventDefault();
			pager('last',function(){returnFunc()})
		})		
			.button({
				label: "last",
				text: false,
				icons: {primary: "ui-icon-seek-end"}
			})
		});
}



function checkDateValid(elem)
{
	re = /^\d{1,2}\/\d{1,2}\/\d{4}$/;
	if($(elem).val() == ''){
		alert("date required");
		$(elem).val().focus();
		return false;
	}

    if($(elem).val() != '' && !$(elem).val().match(re)) {
     
      $(elem).val().focus();
	  
      return false;
    } else { return true; }
}

function checkFieldRequired(elem)
{
	if($(elem).val() === '') {
		return false; 
	} else { 
		return true; 
	}
}

function checkDates(elemDate1, elemDate2)
{
	
	var d1 = $(elemDate1).val().split("/");
	var d2 = $(elemDate2).val().split("/");
	
	var Date1 = new Date(d1[2],d1[1],d1[0]);
	var Date2 = new Date(d2[2],d2[1],d2[0]);

	if (Date1 < Date2){
	 	return true;
	} else {
		return false;
	}
}

function isNumber(n) {
  return !isNaN(parseFloat(n)) && isFinite(n);
}

function isInteger(n) {
  return !isNaN(parseInt(n));
}




  