<?php
error_reporting(0);
session_start();

    $con=mysql_connect("localhost","root","") or die("Could not connect to server");
    $db_name = "PrintBaba";
    mysql_select_db($db_name,$con) or die("Could not open Database");

    $query="select PSN from PSN";
    $result=mysql_query($query);
    $num=mysql_result($result,0,"PSN");
    $psn=str_split($num,3)[1]+1;
    if($psn<10)
    {
        $psn="00" . $psn;
    }
    else if($psn<100)
    {
        $psn="0" . $psn;
    }

    $psn="PB_" . $psn;

    $query="delete PSN from PSN";
    mysql_query($query);
    $query="insert into PSN values('$psn')";
    mysql_query($query);

    $date=date("d/m/y");
    $cust=$_SESSION['cust'];
    $mobile=$_SESSION['mobile'];
    $order=$_SESSION['order'];
    $total=$_SESSION['total'];
    $total_fees=$_SESSION['total_fees'];

    $query="insert into orders values('$psn','$date','$cust','$mobile','$order','$total','$total_fees')";
    mysql_query($query);

    $part=explode("#",$order);
    $count=count($part);
    $c=0;

    //echo"Hola<br><br><br>";
    $msg="Hi ".$cust." Your order for ";
    //echo"<br> ".$cust;
    while($c<$count)
    {
        //echo"".$part[$c]."<br>";
        $msg=$msg  . $part[$c];
        $c++;
    }
    //echo"Total = Rs. ".($total+$total_fees);
    $msg=$msg . " is placed. Total is Rs.".($total+$total_fees)." (*Including PF Rs.2 /Set*) Happy Printing...";
    //echo"<br>".$msg;
    $_SESSION['msg']=$msg;

    session_destroy();
    header("Location:http://localhost/PrintBaba/sendSms.php");
?>
<html>
<head>
<title>Browse Experiments</title>
<link rel="stylesheet" href="style.css" />
<script type="text/javascript">
</script>
</head>

<body>
<form name="frm" method="post" action="http://localhost/PrintBaba/default.php">
    <div id="main">

        <div id="top">
        <img src="res/logo.jpg" alt="PrintBaba"></img>
        <h1>
            P&nbsp;&nbsp;r&nbsp;&nbsp;i&nbsp;&nbsp;n&nbsp;&nbsp;t &nbsp;&nbsp;&nbsp; B&nbsp;&nbsp;a&nbsp;&nbsp;b&nbsp;&nbsp;a
        </h1>
    </div>
    <br> <br><br><br><br><br><br><br><br><br><br>
    <div id="navigation">
    <span id="nav" style="background: hsla(233, 45%, 69%, 1)">
        Get Started
    </span>
    <span id="nav" style="background: hsla(233, 45%, 69%, 1)">
        Browse
    </span>
    <span id="nav" style="background: hsla(233, 45%, 69%, 1)">
        Your Cart
    </span>
    <span id="nav" style="background: hsla(0, 0%, 90%, 0.7)">
        Hola
    </span>
    </div>

        <div class="content" style="margin-left: 2%;margin-top: 7%;">
        <h2>Hola...Your Prints will be delievered shortly...Happy Printing</h2><br><br>
        <input type="submit" class="green" style="margin-left: 40%;" value="Home"/>
        </div>


    </div>
</form>
</body>

</html>