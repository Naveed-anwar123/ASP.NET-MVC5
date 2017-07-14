
function a(){
		var val = document.getElementById("first");	
		var val1 = document.getElementById("error1");
		if(/\d/.test(val.value) &&  val.value!=''){
			val1.innerHTML='<div class="alert alert-danger fade in col-lg-3" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong>    Name must be string</div>';
			return false;
		}
		else if(val.value == ""){
			val1.innerHTML='<div class="alert alert-danger fade in col-lg-3" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong> Cannot be empty</div>';
			return false;
      } 
		else{val1.innerHTML='';return true;}	
}


function b(){
		var val = document.getElementById("lname");	
		var val1 = document.getElementById("error2");
		if(/\d/.test(val.value) &&  val.value!=''){
			val1.innerHTML='<div class="alert alert-danger fade in col-lg-3" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong>    Name must be string</div>';
			return false;
		}
		else if(val.value == ""){
			val1.innerHTML='<div class="alert alert-danger fade in col-lg-3" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong> Cannot be empty</div>';
			return false;
      }

		
		else{val1.innerHTML='';return true;}	
}


function c(){
		var val = document.getElementById("user");	
		var val1 = document.getElementById("error3");
		if(val.value==' '){
			val1.innerHTML='<div class="alert alert-danger fade in col-lg-3" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong> Cannot be empty</div>';
			return false;
		}
		else if(val.value == ""){
			val1.innerHTML='<div class="alert alert-danger fade in col-lg-3" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong> Cannot be empty</div>';
			return false;
      }
		else{val1.innerHTML='';return true;}	
}



       function validateEmail()
    {
        var email = document.getElementById("email").value;
        var val1 = document.getElementById("error5");
      if(email == ""){
			val1.innerHTML='<div class="alert alert-danger fade in col-lg-3" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong> Cannot be empty</div>';
			return false;
      } 
    else if(email.indexOf("@") < 0 ) {
    	val1.innerHTML='<div class="alert alert-danger fade in col-lg-3" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong>Enter valid email address </div>';
			return false;
    }
    
    
    	else{val1.innerHTML='';return true;}	
    
 }

function validatepass(){
		var pass = document.getElementById("pass").value;
        var val1 = document.getElementById("error6");
        if(pass == ""){
			val1.innerHTML='<div class="alert alert-danger fade in col-lg-3" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong> Cannot be empty</div>';
			return false;
      }
	  else{
		  return true;
	  }
    } 


function confirmpass(){
		var pass1 = document.getElementById("pass1").value;
		var pass = document.getElementById("pass").value;
        var val1 = document.getElementById("error7");
        if(pass1 == ""){
			val1.innerHTML='<div class="alert alert-danger fade in col-lg-3" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong>Please confirm password</div>';
			return false;
      }
      else if(pass != pass1){
      	val1.innerHTML='<div class="alert alert-danger fade in col-lg-3" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong>Password did not match</div>';
			return false;	
      }
      else{
      	return true;
      }
    }

function validate(){
	if(a()==true && b()==true && c()== true && validateEmail() &&confirmpass()){
		//alert('true');
		return true;
	}
	else{
		//alert('false');
		return false;
	}
}


