<%@ page language="java" contentType="text/html; charset=ISO-8859-1" pageEncoding="ISO-8859-1"%>

<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="utf-8" />
  <meta http-equiv="X-UA-Compatible" content="IE=edge" />
  <meta name="viewport" content="width=device-width, initial-scale=1" />

  <!-- Title with icon -->
  <link rel="icon" type="image/png" sizes="16x16" href="images/logo/logo.jpg" />
  <title>Mutiny</title>

  <!-- Required CSS files -->
  <link href="css/custom.css" rel="stylesheet" />
  <link href="css/lib/toastr/toastr.min.css" rel="stylesheet" />
  <link href="css/lib/bootstrap/bootstrap.min.css" rel="stylesheet" />
  <link href="css/helper.css" rel="stylesheet" />
  <link href="css/style.css" rel="stylesheet" />
</head>

<body id="login-page">

  <div class="container-fluid offset-md-6">
    <div class="row">
      <div class="col-lg-5">
        <div class="login-content card">
          <div class="login-form">
            <h4>Login to Mutiny</h4>

			<form action="/Mutiny-JSP-Hibernate/LoginController?action=login" method="post">
            <div class="form-group ">
              <div class="col-lg-12">
                <label>Username</label>
                <input type="text" class="form-control" id="username" name="username" placeholder="" />
              </div>
            </div>

            <div class="form-group ">
              <div class="col-lg-12">
                <label>Password</label>
                <input type="password" class="form-control" id="password" name="password" placeholder="" />
              </div>
            </div>

            <div class="form-group ">
              <div class="col-lg-12">
                <a href="sign-up.jsp" class="color-primary">Don't have mutiny account ?</a>
              </div>
            </div>

            <div class="form-group col-lg-6">
              <button type="submit" id="login" class="btn btn-primary btn-flat">
                Log in
              </button>
            </div>
</form>
          </div>
        </div>
      </div>
    </div>
  </div>


</body>

<script src="js/lib/jquery/jquery.min.js"></script>
<script src="js/lib/bootstrap/js/bootstrap.min.js"></script>
<script src="js/lib/toastr/toastr.min.js"></script>
<script src="js/lib/toastr/toastr.init.js"></script>


</html>