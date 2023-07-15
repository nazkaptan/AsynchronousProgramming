﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    //for notifications
    setTimeout(() => {
        $("div.alert.notification").fadeOut();
    }, 2000);

    //delete entity with confirmation
    $("a.confirmDeletion").click(() => {
        if (!confirm("Confirm Deletion")) {
            return false;
        }
    });
});