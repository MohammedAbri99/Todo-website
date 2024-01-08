// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.document.addEventListener("DOMContentLoaded", function () {
// Get all checkboxes in the document
document.addEventListener("DOMContentLoaded", function () {
    // Get all checkboxes in the document
    var checkboxes = document.querySelectorAll('.form-check-input');

    // Iterate over each checkbox
    checkboxes.forEach(function (checkbox) {
        // Add a change event listener to each checkbox
        checkbox.addEventListener('change', function () {
            // Get the <s> element within the parent <li>
            var strikethrough = this.closest('li').querySelector('s');

            // Set the "textDecoration" style based on the checkbox state
            strikethrough.style.textDecoration = this.checked ? 'line-through' : 'none';
        });

        // Initial state handling
        var strikethrough = checkbox.closest('li').querySelector('s');

        // Set the "textDecoration" style only if the checkbox is initially checked
        if (checkbox.checked) {
            strikethrough.style.textDecoration = 'line-through';
        }
    });
});

