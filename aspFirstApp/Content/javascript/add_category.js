function a(){
		var val = document.getElementById("cate");	
		var val1 = document.getElementById("error1");
		if(/\d/.test(val.value) &&  val.value!=''){
			val1.innerHTML='<div class="alert alert-danger fade in col-lg-4" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong>Category must be string</div>';
			return false;
		}
		else if(val.value == ""){
			val1.innerHTML='<div class="alert alert-danger fade in col-lg-4" id="display1"><a href="#" class="close" data-dismiss="alert">&times;</a><strong>Error </strong> Cannot be empty</div>';
			return false;
      } 
		else{val1.innerHTML='';return true;}	
}

function validate(){
	if(a()==true){
		//alert('true');
		return true;
	}
	else{
		//alert('false');
		return false;
	}
}