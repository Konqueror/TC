<!DOCTYPE html>
<head>
     <title>Task 4 Form!</title>
</style> 
<script>
 		window.onload = function(){

 			document.getElementById('form').onclick = function(){

 			var numberOne = document.getElementById('numberOne').value;
 			var sign = document.getElementById('sign').value;
 			var numberTwo = document.getElementById('numberTwo').value;

 			if (numberOne === '' || numberTwo  === '' || sign  === '') {
 				alert('Please fill all the fields.');
				return false;
 			}else if (isNaN(numberOne) || isNaN(numberTwo)) {
 				alert('Please enter valid numbers');
				return false;
 			}else if (sign !== '+' && sign !== '-' && sign !== '*' && sign !== '/' && sign !=='%' && sign !=='^') {
 				alert('Please enter valid sign.');
 				return true;
 			}
 		}
 	}
</script>    
</head>
<body>
<div>
 	<form method="POST" action="calculate.php" name="theForm">
 		<input id="numberOne" type="text" name="numberOne" placeholder="Enter a number"><br>
 		<input id="sign" type="text" name="sign" placeholder="Enter a sign"><br>
 		<input id="numberTwo" type="text" name="numberTwo" placeholder="Enter a number"><br>
 		<input id="form" type="submit" name="submit" value="Run!"/>
 	</form>
 	
</div>
</body>
</html> 
