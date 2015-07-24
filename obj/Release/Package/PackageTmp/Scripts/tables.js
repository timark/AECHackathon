
// Tables.js
// ====================================================================
// ====================================================================
// - ThemeOn.net -



// Format Table
// =================================================================

function invoiceFormatter(value, row) {
    return '<a href="#" class="btn-link text-dark text-thin" > Order #' + value + '</a>';
}


function nameFormatter(value, row) {
    return '<a href="#" class="btn-link" > ' + value + '</a>';
}


function dateFormatter(value, row) {
    var icon = row.id % 2 === 0 ? 'fa-star' : 'fa-user';
    return '<small class="text-muted"><i class="fa fa-clock-o"></i> ' + value + '</span>';
}


function statusFormatter(value, row) {
   var labelColor;
   if (value == "Paid") {
      labelColor = "success";
   }else if(value == "Unpaid"){
      labelColor = "warning";
   }else if(value == "Shipped"){
      labelColor = "info";
   }else if(value == "Refunded"){
      labelColor = "danger";
   }   
   
   var icon = row.id % 2 === 0 ? 'fa-star' : 'fa-user';
   return '<div class="label label-'+ labelColor+' text-lg" style="display:inline-block; width:80%; font-size:1em; max-width:100px; padding:5px"> ' + value + '</div>';
}




function trackFormatter(value, row) {
   if (value) return '<i class="fa fa-plane"></i> ' + value;
}


function priceSorter(a, b) {
    a = +a.substring(1); // remove $
    b = +b.substring(1);
    if (a > b) return 1;
    if (a < b) return -1;
    return 0;
}


// =================================================================






$(document).ready(function() {

   
   
   // Initialize bootstrap table
   // =================================================================
   $('#demo-table').bootstrapTable();

   
});