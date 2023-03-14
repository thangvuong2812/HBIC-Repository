
// Call the dataTables jQuery plugin
const LoadDataToTable = (data, createdRow = null) => {

    console.log(data)
    var table = $('#dataTable').DataTable({
        buttons: [
            'selectAll',
            'selectNone'
        ],
        language: {
            buttons: {
                selectAll: "Select all items",
                selectNone: "Select none"
            }
        },
        data: data,
        rowId: 'userId',
        columns: [
            {
                className: 'details-control text-center',
                orderable: false,
                data: null,
                defaultContent: '<i class="fa fa-address-card" aria-hidden="true"></i>',
                width: '50px'
            },
            { data: "userName" },
            { data: "email" },
            { data: "subjectTitle" },
            { data: "groupTitle" },
            { data: "createdDate" },
            
        ],
        createdRow: createdRow
    }
    );


    $('#dataTable tbody').on('click', 'tr', function () {
        console.log(this);
      
        $(this).toggleClass('selected');
    });


    //Select All
    $('#selectAll-input').change(function () {
        var rows = $('#dataTable tbody tr');
        if (this.checked) {
            rows.addClass('selected');
        }
        else
            rows.removeClass('selected');
    });

    return table;
}
