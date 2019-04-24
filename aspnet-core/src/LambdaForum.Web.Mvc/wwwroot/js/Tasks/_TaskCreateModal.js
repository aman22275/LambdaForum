(function ($) {

    var _userService = abp.services.app.task;
    var _$modal = $('#TaskCreateModal');
   //var _$form = $('#TaskCreationForm');

    $(function () {
       
        var _$form = $('#TaskCreationForm');

        _$form.find('input:first').focus();

        _$form.validate();

        _$form.find('button[type=submit]')
            .click(function (e) {
                e.preventDefault();

                if (!_$form.valid()) {
                    return;
                }

                //serializeFormToObject is used to convert 
                //form data to json object.
                var input = _$form.serializeFormToObject();
                abp.services.app.task.create(input)
                    .done(function () {
                        location.href = '/Task';
                    });
            });
    });

    function save() {
        alert("save pressed");
        if (!_$form.valid()) {
            return;
        }

        var _$form = $('#TaskCreationForm');

        _$form.find('input:first').focus();

        _$form.validate();

        _$form.find('button[type=submit]')
            .click(function (e) {
                e.preventDefault();

                if (!_$form.valid()) {
                    return;
                }

                //serializeFormToObject is used to convert 
                //form data to json object.
                var input = _$form.serializeFormToObject();
                abp.services.app.task.create(input)
                    .done(function () {
                        location.href = '/Task';
                    });
            });
        
        
    }

    //Handle save button click
    _$form.closest('div.modal-content').find(".save-button").click(function (e) {
        e.preventDefault();
        alert("save pressed");
        save();
    });

    $.AdminBSB.input.activate(_$form);

    _$modal.on('shown.bs.modal', function () {
        _$form.find('input[type=text]:first').focus();
    });
})(jQuery);



(function ($) {
    //serializeFormToObject plugin for jQuery
    $.fn.serializeFormToObject = function () {
        //serialize to array
        var data = $(this).serializeArray();

        //add also disabled items
        $(':disabled[name]', this)
            .each(function () {
                data.push({ name: this.name, value: $(this).val() });
            });

        //map to object
        var obj = {};
        data.map(function (x) { obj[x.name] = x.value; });

        return obj;
    };
})(jQuery);