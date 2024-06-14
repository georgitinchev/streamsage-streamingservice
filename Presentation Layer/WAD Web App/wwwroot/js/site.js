// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('.edit-button').click(function () {
        $(this).next('.edit-form').show();
    });

    // Hide the loading spinner
    $('#loadingSpinner').hide();
});

$('form[asp-page-handler="ChangePassword"]').on('submit', function () {
    return confirm('Are you sure you want to change your password?');
});

function toggleEditForm(reviewId) {
    const form = document.getElementById(`edit-form-${reviewId}`);
    form.style.display = form.style.display === "none" ? "block" : "none";
}

function toggleEditForm(reviewId) {
    var form = document.getElementById("edit-form-" + reviewId);
    if (form.style.display === "none" || form.style.display === "") {
        form.style.display = "block";
    } else {
        form.style.display = "none";
    }
}

function toggleEditFormInterpretation(interpretationId) {
    var form = document.getElementById("edit-form-interpretation-" + interpretationId);
    if (form.style.display === "none" || form.style.display === "") {
        form.style.display = "block";
    } else {
        form.style.display = "none";
    }
}

document.addEventListener("DOMContentLoaded", function () {
    const searchForm = document.querySelector("form[action='/Library']");
    if (searchForm) {
        searchForm.addEventListener("submit", function (event) {
            const genreSelect = searchForm.querySelector("select[name='genre']");
            const searchInput = searchForm.querySelector("input[name='searchQuery']");
            if (genreSelect && genreSelect.value === "") {
                genreSelect.disabled = true;
            }
            if (searchInput && searchInput.value.trim() === "") {
                searchInput.disabled = true;
            }
        });
    }
});