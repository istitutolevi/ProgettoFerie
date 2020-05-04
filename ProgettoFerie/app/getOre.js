$(document).ready(function () {
    $.ajax({
        type: 'GET',
        url: 'api/Ore',        
        dataType: json
    });
};