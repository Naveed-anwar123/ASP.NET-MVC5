function validateEmail() {
    
    var email = document.getElementById("email").value;
    var val1 = document.getElementById("error5");
    if (email == "") {
        val1.innerHTML = '<div class="alert alert-danger fade in col-lg-3" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong> Cannot be empty</div>';
        return false;
    }
    else if (email.indexOf('@') < 0) {
        val1.innerHTML = '<div class="alert alert-danger fade in col-lg-3" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong>Enter valid email address </div>';
        return false;
    }


    else { val1.innerHTML = ''; return true; }

}

function validatepass() {
    
    var pass = document.getElementById("pass").value;
    var val1 = document.getElementById("error6");
    if (pass == "") {

        val1.innerHTML = '<div class="alert alert-danger fade in col-lg-3" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong> Cannot be empty</div>';
        return false;
    }
    else {
        return true;
    }
}


function validate() {
    if (validateEmail() == true && validatepass() == true) {
        
        return true;
    }
    else {
        alert('false');
        return false;
    }
}