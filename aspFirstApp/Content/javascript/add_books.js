
function a(){
		var val = document.getElementById("books");	
		var val1 = document.getElementById("error1");
		if(/\d/.test(val.value) &&  val.value!=''){
			val1.innerHTML='<div class="alert alert-danger fade in col-lg-5" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong>    Name must be string</div>';
			return false;
		}
		else if(val.value == ""){
			val1.innerHTML='<div class="alert alert-danger fade in col-lg-5" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong> Cannot be empty</div>';
			return false;
      } 
		else{val1.innerHTML='';return true;}	
}


function b(){
		var val = document.getElementById("isbn");	
		var val1 = document.getElementById("error2");
		if(isNaN(val.value) &&  val.value!=''){
			val1.innerHTML='<div class="alert alert-danger fade in col-lg-5" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong>    ISBN must be integer</div>';
			return false;
		}
		else if(val.value == ""){
			val1.innerHTML='<div class="alert alert-danger fade in col-lg-5" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong> Cannot be empty</div>';
			return false;
      } 
		else{val1.innerHTML='';return true;}	
}



function validate(){
	if(a()==true && b()==true){
		return true;
	}
	else{
		return false;
	}
}
