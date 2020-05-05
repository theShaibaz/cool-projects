<?php

error_reporting(0);
session_start();
$_SESSION['var']=1;
$_SESSION['cust']=$_POST['cust'];
$_SESSION['mobile']=$_POST['mobile'];
header("Location:http://localhost/PrintBaba/browse.php");

?>