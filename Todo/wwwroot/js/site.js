// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

$(document).ready(function () {
    // Wire up all of the checkboxes to run markCompleted()
    $('.done-checkbox').on('click', function (e) {
        markCompleted(e.target);
    });

    $('input[type=date]').each(function () {
        this.min = new Date().toISOString().substr(0, 10);
    });
});

function markCompleted(checkbox) {
    checkbox.disabled = true;
    const row = checkbox.closest('tr');
    $(row).addClass('done');
    const form = checkbox.closest('form');
    form.submit();
}