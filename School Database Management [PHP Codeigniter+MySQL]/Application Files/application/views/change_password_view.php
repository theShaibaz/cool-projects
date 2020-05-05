<div class="row justify-content-center">
  <div class="col-lg-12">
    <div class="card">
      <div class="card-body">
        <div class="form-validation">

          <form class="form-valide" action="<?php echo base_url(); ?>login/update_password" method="post">

            <div class="form-group row">
              <div class="col-lg-6">
                <h3 class="card-title m-t-15">Select User</h3>
                <hr>
                <div class="form-group row">
                  <div class="col-lg-4">
                    <select class="form-control" id="user" name="user">
                      <option value="user">User</option>
                      <option value="admin">Admin</option>
                    </select>
                  </div>
                  <div class="col-lg-8">
                    <input type="password" id="password" name="password" class="form-control" id="newpassword" name="newpassword"
                    placeholder="Enter New Password">
                  </div>
                </div>

                <div class="form-group row">
                  <div class="col-lg-4">
                    <button type="reset" class="btn btn-dark btn-flat col-lg-12">Reset</button>
                  </div>
                  <div class="col-lg-8">
                    <button type="submit" id="change" name="change" class="btn btn-info btn-flat col-lg-12">Change Password</button>
                  </div>
                </div>
              </div>

            </div>
          </div>

          </form>
        </div>
      </div>
    </div>
  </div>
</div>
<!-- End Page Content -->

<?php

  // Showing toastr messages
  if($this->input->cookie('message_code')==2){
    echo "<script>";
    echo "$(document).ready(function(){";
    echo "info('Password changed','Successful');";
    echo "});";
    echo "</script>";
  }
  if($this->input->cookie('message_code')==3){
    echo "<script>";
    echo "$(document).ready(function(){";
    echo "warning('Enter new password','Check Input');";
    echo "});";
    echo "</script>";
  }
  if($this->input->cookie('message_code')==4){
    echo "<script>";
    echo "$(document).ready(function(){";
    echo "error('Password not changed','Unsuccessful');";
    echo "});";
    echo "</script>";
  }

?>
