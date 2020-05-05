<!DOCTYPE HTML>

<?php
error_reporting(0);
session_start();

if($_SESSION['var']=='')
{
    header("Location:http://localhost/PrintBaba/default.php");
}
else
{
    $con=mysql_connect("localhost","root","") or die("Could not connect to server");
    $db_name = "PrintBaba";
    mysql_select_db($db_name,$con) or die("Could not open Database");

    //echo" CUST= ".$_SESSION['cust'];
    //echo" MOBILE= ".$_SESSION['mobile'];
}
?>

<html>
<head>
<title>Browse Experiments</title>
<link rel="stylesheet" href="style.css" />
<script type="text/javascript">

function proceed()
{
    document.frm.action="http://localhost/PrintBaba/showCart.php";
    document.frm.Submit();
}
function addToCart()
{
    document.frm.action="http://localhost/PrintBaba/addToCart.php";
    document.frm.Submit();
}
function showExp()
{
    document.frm.action="http://localhost/PrintBaba/showExp.php";
    document.frm.submit();
}

</script>
</head>

<body>
<form name="frm" method="post">
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
    <span id="nav" style="background: hsla(0, 0%, 90%, 0.7)">
        Browse
    </span>
    <span id="nav" style="background: hsla(233, 45%, 69%, 1)">
        Your Cart
    </span>
    <span id="nav" style="background: hsla(233, 45%, 69%, 1)">
        Hola
    </span>
    </div>

        <div class="content" style="margin-left: 30%;margin-top: 7%;">

            <?php

            $row=0;
            if(isset($_SESSION['sub']))
            {
                $sub=$_SESSION['sub'];
            }
            else
            {
                $sub="";
            }
            $query="select Experiment_Name from Experiments where Subject_Name='$sub'";
            $result=mysql_query($query);
            $exp_count=mysql_num_rows($result);

            echo"<select name='sub' onchange='showExp()' style='margin-left: 11%; '>";

            if($sub=="CC")
            {
                echo"<option value='Select Subject'>Select Subject</option>";
                echo"<option value='CC' selected='selected'>CC</option>";
                echo"<option value='IP'>IP</option>";
                echo"<option value='IS'>IS</option>";
                echo"<option value='SPM'>SPM</option>";
                echo"<option value='UC'>UC</option>";
                echo"<option value='WT'>WT</option>";
            }

            else if($sub=="IP")
            {
                echo"<option value='Select Subject'>Select Subject</option>";
                echo"<option value='CC'>CC</option>";
                echo"<option value='IP' selected='selected'>IP</option>";
                echo"<option value='IS'>IS</option>";
                echo"<option value='SPM'>SPM</option>";
                echo"<option value='UC'>UC</option>";
                echo"<option value='WT'>WT</option>";
            }

            else if($sub=="IS")
            {
                echo"<option value='Select Subject'>Select Subject</option>";
                echo"<option value='CC'>CC</option>";
                echo"<option value='IP'>IP</option>";
                echo"<option value='IS' selected='selected'>IS</option>";
                echo"<option value='SPM'>SPM</option>";
                echo"<option value='UC'>UC</option>";
                echo"<option value='WT'>WT</option>";
            }

            else if($sub=="SPM")
            {
                echo"<option value='Select Subject'>Select Subject</option>";
                echo"<option value='CC'>CC</option>";
                echo"<option value='IP'>IP</option>";
                echo"<option value='IS'>IS</option>";
                echo"<option value='SPM' selected='selected'>SPM</option>";
                echo"<option value='UC'>UC</option>";
                echo"<option value='WT'>WT</option>";
            }

            else if($sub=="UC")
            {
                echo"<option value='Select Subject'>Select Subject</option>";
                echo"<option value='CC'>CC</option>";
                echo"<option value='IP'>IP</option>";
                echo"<option value='IS'>IS</option>";
                echo"<option value='SPM'>SPM</option>";
                echo"<option value='UC' selected='selected'>UC</option>";
                echo"<option value='WT'>WT</option>";
            }

            else if($sub=="WT")
            {
                echo"<option value='Select Subject'>Select Subject</option>";
                echo"<option value='CC'>CC</option>";
                echo"<option value='IP'>IP</option>";
                echo"<option value='IS'>IS</option>";
                echo"<option value='SPM'>SPM</option>";
                echo"<option value='UC'>UC</option>";
                echo"<option value='WT' selected='selected'>WT</option>";
            }
            else
            {
                echo"<option value='Select Subject' selected='selected'>Select Subject</option>";
                echo"<option value='CC'>CC</option>";
                echo"<option value='IP'>IP</option>";
                echo"<option value='IS'>IS</option>";
                echo"<option value='SPM'>SPM</option>";
                echo"<option value='UC'>UC</option>";
                echo"<option value='WT'>WT</option>";
            }
            echo"</select>";

            if($exp_count>0)
            {
                echo"<select name='exp' style='margin-left: 50px; '>";
                //echo"<option value='Select Experiment'>Select Experiment</option>";
                while($exp_count>0)
                {
                    echo"<option>".mysql_result($result,$row,"Experiment_Name");
                    echo"</option>";
                    $exp_count--;
                    $row++;
                }
                echo"</select><br><br><br>";
                echo"<input type='number' class='qty' name='qty' placeholder='Qty' min='1' max='5' value='1'/><br><br><br>";
                echo"<input type='submit' class='green' onclick='addToCart()' value='Add To Cart' style='margin-left: 10%;'/>";
                $order=$_SESSION['order'];
                if($order<>"")
                {
                    echo"<br><br><input type='submit' class='green' onclick='proceed()' value='Proceed' style='margin-left: 10%;'/>";
                }
            }

            ?>

        </div>


    </div>
</form>
</body>

</html>