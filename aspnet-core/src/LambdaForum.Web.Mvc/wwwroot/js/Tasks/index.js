//Task index file
(function () {
    $(function() {

             var _userService = abp.services.app.task;
             var _$modal = $('#TaskCreateModal');
             var _$form = _$modal.find('form');

        //Code to pop up the Create task form.
        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });

        function refreshUserList() {
            location.reload(true); //reload page to see new user!
        }

        //Delete task functionality , without using controller.
        $('.delete-user').click(function () {
            var userId = $(this).attr("data-user-id");
            var userName = $(this).attr('data-user-name');

            deleteUser(userId, userName);
        });

        function deleteUser(userId, userName) {
            abp.message.confirm(
                abp.utils.formatString(abp.localization.localize('AreYouSureWantToDelete', 'LambdaForum'), userName),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _userService.delete({
                            id: userId
                        }).done(function () {
                            refreshUserList();
                        });
                    }
                }
            );
        }

        //Edit task functionality , without using controller.
        //This will bring data into your form to edit it.
        $('.edit-user').click(function (e) {
            var userId = $(this).attr("data-user-id");

            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'Task/EditTaskModal?userId=' + userId,
                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#TaskEditModal div.modal-content').html(content);
                },
                error: function (e) { }
            });
        });



 });
})();