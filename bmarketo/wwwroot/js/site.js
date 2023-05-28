try {
    const toggleBtn = document.querySelector('[data-option="toggle"]')
    toggleBtn.addEventListener('click', function() {
        const element = document.querySelector(toggleBtn.getAttribute('data-target'))
        
        if (!element.classList.contains('open-menu')) {
            element.classList.add('open-menu')
            toggleBtn.classList.add('btn-outline-dark')
            toggleBtn.classList.add('btn-toggle-white')
        }

        else {
            element.classList.remove('open-menu')
            toggleBtn.classList.remove('btn-outline-dark')
            toggleBtn.classList.remove('btn-toggle-white')
        }
    })    
} catch { }




    document.addEventListener('DOMContentLoaded', function() {
        var form = document.querySelector('form');
    var firstNameInput = document.getElementById('FirstName');
    var lastNameInput = document.getElementById('LastName');
    var emailInput = document.getElementById('Email');
    var streetNameInput = document.getElementById('StreetName');
    var postalCodeInput = document.getElementById('PostalCode');
    var cityInput = document.getElementById('City');
    var countryInput = document.getElementById('Country');
    var passwordInput = document.getElementById('Password');
    var confirmPasswordInput = document.getElementById('ConfirmPassword');

    form.addEventListener('submit', function(event) {
            if (!validateForm()) {
        event.preventDefault();
            }
        });

    function validateForm() {
            var isValid = true;

    // Validate First Name
    if (firstNameInput.value.trim() === '') {
        isValid = false;
    showErrorMessage(firstNameInput, 'First Name is required.');
            } else {
        hideErrorMessage(firstNameInput);
            }

    // Validate Last Name
    if (lastNameInput.value.trim() === '') {
        isValid = false;
    showErrorMessage(lastNameInput, 'Last Name is required.');
            } else {
        hideErrorMessage(lastNameInput);
            }

    // Validate Email
    if (emailInput.value.trim() === '') {
        isValid = false;
    showErrorMessage(emailInput, 'Email is required.');
            } else {
        hideErrorMessage(emailInput);
            }

    // Validate Street Name
    if (streetNameInput.value.trim() === '') {
        isValid = false;
    showErrorMessage(streetNameInput, 'Street Name is required.');
            } else {
        hideErrorMessage(streetNameInput);
            }

    // Validate Postal Code
    if (postalCodeInput.value.trim() === '') {
        isValid = false;
    showErrorMessage(postalCodeInput, 'Postal Code is required.');
            } else {
        hideErrorMessage(postalCodeInput);
            }

    // Validate City
    if (cityInput.value.trim() === '') {
        isValid = false;
    showErrorMessage(cityInput, 'City is required.');
            } else {
        hideErrorMessage(cityInput);
            }

    // Validate Country
    if (countryInput.value.trim() === '') {
        isValid = false;
    showErrorMessage(countryInput, 'Country is required.');
            } else {
        hideErrorMessage(countryInput);
            }

    // Validate Password
    if (passwordInput.value.trim() === '') {
        isValid = false;
    showErrorMessage(passwordInput, 'Password is required.');
            } else {
        hideErrorMessage(passwordInput);
            }

    // Validate Confirm Password
    if (confirmPasswordInput.value.trim() === '') {
        isValid = false;
    showErrorMessage(confirmPasswordInput, 'Confirm Password is required.');
            } else if (confirmPasswordInput.value !== passwordInput.value) {
        isValid = false;
    showErrorMessage(confirmPasswordInput, 'Passwords do not match.');
            } else {
        hideErrorMessage(confirmPasswordInput);
            }

    return isValid;
        }

    function showErrorMessage(input, message) {
            var errorMessage = input.parentElement.querySelector('.text-danger');
    errorMessage.textContent = message;
    input.classList.add('is-invalid');
        }

    function hideErrorMessage(input) {
            var errorMessage = input.parentElement.querySelector('.text-danger');
    errorMessage.textContent = '';
    input.classList.remove('is-invalid');
        }
    });

