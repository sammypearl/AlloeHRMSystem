
var AddEditEmployeeInfo = function (id) {
    var url = "/EmployeeInfo/AddEditEmployeeInfo?id=" + id;
    if (id > 0)
        $('#title').html("Edit Personal Info");

    $("#EmployeeInfoFormModelDiv").load(url, function () {
        $("#EmployeeInfoFormModel").modal("show");

    });
};

$('body').on('click', "#btnSubmit", function () {
    var myformdata = $("#EmployeeInfoForm").serialize();

    if ($.trim($('#Name').val()) === '') {
        Swal.fire({
            title: "Alert", text: "First Name can not be left blank.",
            icon: "info", closeOnConfirm: false,
            onAfterClose: () => {
                setTimeout(() => $("#Name").focus(), 110);
            }
        });
        return;
    }
    if ($.trim($('#Surname').val()) === '') {
        Swal.fire({
            title: "Alert", text: "Last Name can not be left blank.",
            icon: "info", closeOnConfirm: false,
            onAfterClose: () => {
                setTimeout(() => $("#Surname").focus(), 110);
            }
        });
        return;
    }


    if ($.trim($('#DateOfBirth').val()) === '') {
        Swal.fire({
            title: "Alert", text: "Date Of Birth can not be left blank.",
            icon: "info", closeOnConfirm: false,
            onAfterClose: () => {
                setTimeout(() => $("#DateOfBirth").focus(), 110);
            }
        });
        return;
    }

    $.ajax({
        type: "POST",
        url: "/EmployeeInfo/Create",
        data: myformdata,
        success: function (result) {
            $("#EmployeeInfoFormModel").modal("hide");

            Swal.fire({
                title: "Alert!",
                text: result,
                type: "Success"
            }).then(function () {
                $('#tblEmployeeInfo').DataTable().ajax.reload();
            });
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
});

var DeleteEmployeeInfo = function (id) {
    Swal.fire({
        title: 'Do you want to delete this item?',
        type: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes'
    }).then((result) => {
        if (result.value) {
            $.ajax({
                type: "POST",
                url: "/EmployeeInfo/Delete/" + id,
                success: function () {
                    Swal.fire({
                        title: 'Deleted!', text: 'Item has been deleted.',
                        icon: "success", closeOnConfirm: false,
                        onAfterClose: () => {
                            $('#tblEmployeeInfo').DataTable().ajax.reload();
                        }
                    });
                }
            });
        }
    });
};
