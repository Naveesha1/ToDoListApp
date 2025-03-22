// This file will be placed in wwwroot/js/site.js

document.addEventListener('DOMContentLoaded', function () {
    // Add event listeners to any delete buttons
    document.querySelectorAll('.btn-danger').forEach(function (button) {
        button.addEventListener('click', function (e) {
            if (!confirm('Are you sure you want to delete this item?')) {
                e.preventDefault();
            }
        });
    });

    // Highlight completed and pending items differently
    document.querySelectorAll('tr').forEach(function (row) {
        const statusButton = row.querySelector('.btn-success');
        if (statusButton) {
            row.classList.add('table-success');
        }
    });
});