<div class="row justify-content-center">
  <div class="col-lg-12">
    <div class="card">
      <div class="card-body">
        <div class="form-validation">

          <!-- value="<?php echo $this->input->cookie('grnumber'); ?>" -->
          <!-- This line of code will restore previously entered value from cookie -->
          <form class="form-valide" action="<?php echo base_url(); ?>student/update_student" method="post">
            <div class="form-group row">
              <div class="col-lg-6">
                <h3 class="card-title m-t-15">Personal</h3>
                <hr>
                <div class="form-group row">
                  <div class="col-lg-6">
                    <label>GR Number <span style="color:red">*</span></label>
                    <input type="text" class="form-control" id="grnumber" name="grnumber"
                    readonly placeholder="Enter GR Number" value="<?php echo $student[0]['gr_number']; ?>">
                  </div>
                  <div class="col-lg-6">
                    <label>Full Name <span style="color:red">*</span></label>
                    <input type="text" class="form-control" id="fullname" name="fullname"
                    readonly placeholder="Enter Full Name" value="<?php echo $student[0]['name']; ?>">
                  </div>
                </div>

                <div class="form-group row">
                  <div class="col-lg-6">
                    <label>Class <span style="color:red">*</span></label>
                    <input type="text" class="form-control" id="class" name="class"
                    readonly placeholder="Enter Full Name" value="<?php echo $student[0]['class']; ?>">
                  </div>
                  <div class="col-lg-6">
                    <label>Division <span style="color:red">*</span></label>
                    <input type="text" class="form-control" id="division" name="division"
                    readonly placeholder="Enter Full Name" value="<?php echo $student[0]['division']; ?>">
                  </div>
                </div>
              </div>

              <div class="col-lg-6">
                <h3 class="card-title m-t-15">Contact</h3>
                <hr>
                <div class="form-group row">
                  <div class="col-lg-6">
                    <label>Contact Number <span style="color:red">*</span></label>
                    <input type="text" class="form-control" id="contact" name="contact"
                    placeholder="Enter Contact Number"
                    value="<?php if($this->input->cookie('contact')){echo $this->input->cookie('contact');} else{echo $student[0]['contact'];} ?>">
                  </div>
                  <div class="col-lg-6">
                    <label>Alternate Contact</label>
                    <input type="text" class="form-control" id="altcontact" name="altcontact"
                    placeholder="Enter Alternate Contact"
                    value="<?php if($this->input->cookie('altcontact')){echo $this->input->cookie('altcontact');} else{echo $student[0]['alt_contact'];} ?>">
                  </div>
                </div>
                <div class="form-group row">
                  <div class="col-lg-12">
                    <label>Email ID</label>
                    <input type="text" class="form-control" id="email" name="email"
                    placeholder="Enter Email ID"
                    value="<?php if($this->input->cookie('email')){echo $this->input->cookie('email');} else{echo $student[0]['email'];} ?>">
                  </div>
                </div>
              </div>

              <div class="col-lg-6">
                <h3 class="card-title m-t-15">Address</h3>
                <hr>
                <div class="form-group row">
                  <div class="col-lg-12">
                    <label>Area Landmark</label>
                    <input type="text" class="form-control" id="landmark" name="landmark"
                    placeholder="Enter Area Landmark"
                    value="<?php if($this->input->cookie('landmark')){echo $this->input->cookie('landmark');} else{echo $student[0]['landmark'];} ?>">
                  </div>
                </div>
                <div class="form-group row">
                  <div class="col-lg-12">
                    <label>Address <span style="color:red">*</span></label>
                    <textarea class="form-control" rows="5" id="address" name="address" placeholder="Enter Address" style="height:100%;"><?php if($this->input->cookie('address')){echo $this->input->cookie('address');} else{echo $student[0]['address'];} ?></textarea>
                  </div>
                </div>
              </div>

              <div class="col-lg-6">
                <h3 class="card-title m-t-15">Miscellaneous</h3>
                <hr>
                <div class="form-group row">
                  <div class="col-lg-12">
                    <label>Aadhar Number</label>
                    <input type="text" class="form-control" id="aadhar" name="aadhar"
                    placeholder="Enter Aadhar Number"
                    value="<?php if($this->input->cookie('aadhar')){echo $this->input->cookie('aadhar');} else{echo $student[0]['aadhar'];} ?>">
                  </div>
                </div>
                <div class="form-group row">
                  <div class="col-lg-12">
                    <label>Comment</label>
                    <textarea class="form-control" rows="5" id="comment" name="comment" placeholder="Enter Comment" style="height:100%;"><?php if($this->input->cookie('comment')){echo $this->input->cookie('comment');} else{echo $student[0]['comment'];} ?></textarea>
                  </div>
                </div>
              </div>
            </div>

            <br>

            <div class="form-group row">
              <div class="col-lg-8">
                <button type="submit" class="btn btn-info offset-lg-7">Update Student</button>
                <button type="button" id="close" class="btn btn-dark">Close</button>
              </div>
            </div>

          </form>
        </div>
      </div>
    </div>
  </div>
</div>
    <!-- End Page Content -->

<script>

    $(document).ready(function(){
      $('#close').click(function(e){
      window.close();
      });
    });

</script>


    <?php

      // Showing toastr messages
      if($this->input->cookie('message_code')==1){
        echo "<script>";
        echo "$(document).ready(function(){";
        echo "success('Student updated','Successful');";
        echo "});";
        echo "</script>";
      }
      if($this->input->cookie('message_code')==3){
        echo "<script>";
        echo "$(document).ready(function(){";
        echo "warning('".$this->input->cookie('message')."','Check Input');";
        echo "});";
        echo "</script>";
      }
      if($this->input->cookie('message_code')==4){
        echo "<script>";
        echo "$(document).ready(function(){";
        echo "error('Student not updated','Unsuccessful');";
        echo "});";
        echo "</script>";
      }

    ?>
