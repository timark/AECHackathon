var pageSize = 10;
var currentPage = 1;
var PageType = 'List';
function initPager() {
    //$('#menu-organisation').addClass("active-sub")
    Pager()
    $(function () {
        $("#btn_search_records")
            .bind("click", function (event) {
                event.preventDefault();
                searchRecords()
            })
    })
    $(function () {
        $("#btn_reload_records")
            .bind("click", function (event) {
                event.preventDefault();
                reloadRecords()
            })
    })
    $(function () {
        $("#btn_list_records")
            .bind("click", function (event) {
                event.preventDefault();
                setSearchButton('list')
            })
    })
    $(function () {
        $("#btn_panel_records")
            .bind("click", function (event) {
                event.preventDefault();
                setSearchButton('panel')
            })
    })
    $(function () {
        $("#btn_grid_records")
            .bind("click", function (event) {
                event.preventDefault();
                setSearchButton('grid')
            })
    })

}


function reloadRecords() {
    alert('reload')
}

function setSearchButton(displayType) {
    //reset all buttons
    $("#frmSearch button").removeClass("btn-primary")

    if (displayType == "list") {
        PageType = 'List'
        $("#btn_list_records").addClass("btn-primary")
    }
    else if (displayType == "panel") {
        PageType = 'Panel'
        $("#btn_panel_records").addClass("btn-primary")
    }
    else if (displayType == "grid") {
        PageType = 'Grid'
        $("#btn_grid_records").addClass("btn-primary")
    }
    GetRecordSet(PageType,currentPage)

}

