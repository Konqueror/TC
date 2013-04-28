<?php
	$numberOne = $_POST['numberOne'];
	$numberTwo = $_POST['numberTwo'];

	switch ($_POST['sign']) {
		case '+':
			$result = $numberOne + $numberTwo;
			break;
		case '-':
			$result = $numberOne - $numberTwo;
			break;
		case '*':
			$result = $numberOne * $numberTwo;
			break;
		case '/':
			$result = $numberOne / $numberTwo;
			break;
		case '%':
			$result = $numberOne % $numberTwo;
			break;
		case '^':
			$result = pow($numberOne, $numberTwo);
			break;
	}

	echo " $numberOne ".$_POST['sign']." $numberTwo = ".$result."";
?>