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
        <div class="login-content">
          <div class="card">
            <div class="card-body">
            
			<form action="/Mutiny-JSP-Hibernate/LoginController?action=sign-up" method="post">
              <div class="login-form">
                <h4>Join Mutiny</h4>

                <div class="form-group">
                  <div class="form-group row">
                    <div class="col-lg-6">
                      <label>Username</label>
                      <input type="text" class="form-control" id="username" name="username" placeholder="" />
                    </div>
                    <div class="col-lg-6">
                      <label>Password</label>
                      <input type="password" class="form-control" id="password" name="password" placeholder="" />
                    </div>
                  </div>

                  <div class="form-group row">
                    <div class="col-lg-6">
                      <label>Birthdate</label>
                      <input type="date" class="form-control" id="birthdate" name="birthdate" placeholder="" />
                    </div>
                    <div class="col-lg-6">
                      <label>Gender</label>
                      <select class="form-control" id="gender" name="gender">
                        <option value="M" selected>Male</option>
                        <option value="F">Female</option>
                        <option value="O">Other</option>
                      </select>
                    </div>
                  </div>

                  <div class="form-group row">
                    <div class="col-lg-12">
                      <a href="login.jsp" class="color-primary">Already have an mutiny account ?</a>
                    </div>
                  </div>
                </div>


                <div class="form-group row col-lg-6">
                  <button type="submit" id="login" class="btn btn-primary btn-flat">
                    Sign Up
                  </button>
                </div>
              </div>
     	</form>
            </div>
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