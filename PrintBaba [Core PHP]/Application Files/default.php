<!DOCTYPE HTML>

<?php
error_reporting(0);
session_start();
$_SESSION['var']=1;

$con=mysql_connect("localhost","root","") or die("Could not connect to server");
$db_name= "PrintBaba";
mysql_select_db($db_name,$con) or die("Could not open Database");
//echo"connected";

$cust="";
$mobile="";
$order="";
$total=0;
$total_fees=0;
$_SESSION['cust']=$cust;
$_SESSION['mobile']=$mobile;
$_SESSION['order']=$order;
$_SESSION['total']=$total;
$_SESSION['total_fees']=$total_fees;

 ?>

<html>
<head>
<title>Welocome to PrintBaba</title>
<link rel="stylesheet" href="style.css" />
<script type="text/javascript">
function val()
{
    var cust=document.getElementById("cust");
    var mobile=document.getElementById("mobile");
    if(cust.value.length==0)
    {
        alert("Please Enter Your Name");
    }
    else if(mobile.value.length==0)
    {
        alert("Please Enter Your Mobile");
    }
    else
    {
        //document.frm.;
        document.frm.Submit();
    }
}
</script>
</head>

<body>
<form name="frm" method="post" action="http://localhost/PrintBaba/init.php">
  <div id="main">

    <div id="top">
        <img src="res/logo.jpg" alt="PrintBaba"></img>
        <h1>
            P&nbsp;&nbsp;r&nbsp;&nbsp;i&nbsp;&nbsp;n&nbsp;&nbsp;t &nbsp;&nbsp;&nbsp; B&nbsp;&nbsp;a&nbsp;&nbsp;b&nbsp;&nbsp;a
        </h1>
    </div>
    <br> <br><br><br><br><br><br><br><br><br><br>
    <div id="navigation">
    <span id="nav" style="background: hsla(0, 0%, 90%, 0.7)">
        Get Started
    </span>
    <span id="nav" style="background: hsla(233, 45%, 69%, 1)">
        Browse
    </span>
    <span id="nav" style="background: hsla(233, 45%, 69%, 1)">
        Your Cart
    </span>
    <span id="nav" style="background: hsla(233, 45%, 69%, 1)">
        Hola
    </span>
    </div>
    <div class="content" style="margin-left: 40%;">
    <input type="text" id="cust" name="cust" placeholder="Your Name" /><br><br><br>
    <input type="text" id="mobile" name="mobile" placeholder="10 Digit Mobile Number" /><br><br><br><br><br>
    <input type="submit"  class="green" style="margin-left:-1px;" onclick="val()" value="Get Started"/>
    </div>
  </div>
</form>
</body>

</html>