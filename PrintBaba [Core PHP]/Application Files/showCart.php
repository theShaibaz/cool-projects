<!DOCTYPE HTML>

<html>
<head>
<title>Your Cart</title>
<link rel="stylesheet" href="style.css" />
<script type="text/javascript">
function clearCart()
{
    document.frm.action="http://localhost/PrintBaba/clearCart.php";
    document.frm.submit();
}
function placeOrder()
{
    document.frm.action="http://localhost/PrintBaba/placeOrder.php";
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
    <span id="nav" style="background: hsla(233, 45%, 69%, 1)">
        Browse
    </span>
    <span id="nav" style="background: hsla(0, 0%, 90%, 0.7)">
        Your Cart
    </span>
    <span id="nav" style="background: hsla(233, 45%, 69%, 1)">
        Hola
    </span>
    </div>

    <div class="content" style='margin-left: 35%;'>

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

    $order=$_SESSION['order'];
    $total=$_SESSION['total'];
    $total_fees=$_SESSION['total_fees'];
    
        echo"<table cellspacing='5px' cellpadding='5px' border=1>";
        echo"<tr><td>Order</td><td>Cost</td><td>Fees</td></tr>";
        $part=explode("#",$order);
        $count=count($part);
        $c=0;
        //echo"<tr><td width='300'>";
        while($c<count($part))
        {
            echo"<tr><td>";
            echo"".$part[$c];
            echo"</td>";
            if($c==0)
            {
                echo"<td rowspan=".$count.">".$total."</td>";
                echo"<td rowspan=".$count.">".$total_fees."</td></tr>";
            }
            //echo"</tr>";
            $c++;
        }
        //echo"</td>";
        //echo"<td>".$total."</td>";
        //echo"<td>".$total_fees."</td></tr>";
        echo"</table>";
    }
    ?>
    <br><br>
    <input type="submit" class="green" onclick="placeOrder()" value="Place Order" style="margin-left: 2%;"/><br><br>
    <input type="submit" class="red" onclick="clearCart()" value="Clear Cart" style="margin-left: 2%;"/><br><br><br>
    </div>


  </div>
</form>
</body>

</html>