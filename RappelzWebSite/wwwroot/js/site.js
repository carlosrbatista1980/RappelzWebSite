// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

(function() {
    'use strict';

    $(onJQueryLoad);
    function onJQueryLoad() {
        var $loginForm = $('#LoginForm');
        $("#LoginButton").click(onLoginButtonClick);

        function onLoginButtonClick(e) {
            e.preventDefault();

            var dataToParse = {
                    tenancyName: $("#TenancyName").val(),
                    usernameOrEmailAddress: $("#EmailAddressInput").val(),
                    password: $("#PasswordInput").val(),
                    rememberMe: $("#RememberMeInput").is(":checked")
                },
                ajaxConfiguration = {
                    url: $loginForm.attr('action'),
                    type: "POST",
                    data: JSON.stringify(dataToParse),
                };

            abp.ui.setBusy($("#LoginArea"), abp.ajax(ajaxConfiguration));
        }
    }
}());
