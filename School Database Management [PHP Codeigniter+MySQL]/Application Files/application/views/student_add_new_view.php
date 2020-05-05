<div class="row justify-content-center">
  <div class="col-lg-12">
    <div class="card">
      <div class="card-body">
        <div class="form-validation">

          <!-- value="<?php echo $this->input->cookie('grnumber'); ?>" -->
          <!-- This line of code will restore previously entered value from cookie -->
          <form class="form-valide" action="<?php echo base_url(); ?>student/add_new_student" method="post">
            <div class="form-group row">
              <div class="col-lg-6">
                <h3 class="card-title m-t-15">Personal</h3>
                <hr>
                <div class="form-group row">
                  <div class="col-lg-6">
                    <label>GR Number <span style="color:red">*</span></label>
                    <input type="text" class="form-control" id="grnumber" name="grnumber"
                    placeholder="Enter GR Number" value="<?php echo $this->input->cookie('grnumber'); ?>">
                  </div>
                  <div class="col-lg-6">
                    <label>Full Name <span style="color:red">*</span></label>
                    <input type="text" class="form-control" id="fullname" name="fullname"
                    placeholder="Enter Full Name" value="<?php echo $this->input->cookie('fullname'); ?>">
                  </div>
                </div>

                <div class="form-group row">
                  <div class="col-lg-6">
                    <label>Class <span style="color:red">*</span></label>
                    <select class="form-control" id="class" name="class">
                      <option value="">Select Class</option>
                      <option value="First" <?php if($this->input->cookie('class')=='First'){echo "selected";}?>>First</option>
                      <option value="Second" <?php if($this->input->cookie('class')=='Second'){echo "selected";}?> >Second</option>
                      <option value="Third" <?php if($this->input->cookie('class')=='Third'){echo "selected";}?> >Third</option>
                      <option value="Forth" <?php if($this->input->cookie('class')=='Forth'){echo "selected";}?> >Forth</option>
                      <option value="Fifth" <?php if($this->input->cookie('class')=='Fifth'){echo "selected";}?> >Fifth</option>
                      <option value="Sixth" <?php if($this->input->cookie('class')=='Sixth'){echo "selected";}?> >Sixth</option>
                      <option value="Seventh" <?php if($this->input->cookie('class')=='Seventh'){echo "selected";}?> >Seventh</option>
                      <option value="Eighth" <?php if($this->input->cookie('class')=='Eighth'){echo "selected";}?> >Eighth</option>
                      <option value="Nineth" <?php if($this->input->cookie('class')=='Nineth'){echo "selected";}?> >Nineth</option>
                      <option value="Tenth" <?php if($this->input->cookie('class')=='Tenth'){echo "selected";}?> >Tenth</option>
                    </select>
                  </div>
                  <div class="col-lg-6">
                    <label>Division <span style="color:red">*</span></label>
                    <select class="form-control" id="division" name="division">
                      <option value="">Select Division</option>
                      <option value="A" <?php if($this->input->cookie('division')=='A'){echo "selected";}?> >A</option>
                      <option value="B" <?php if($this->input->cookie('division')=='B'){echo "selected";}?> >B</option>
                      <option value="C" <?php if($this->input->cookie('division')=='C'){echo "selected";}?> >C</option>
                      <option value="D" <?php if($this->input->cookie('division')=='D'){echo "selected";}?> >D</option>
                    </select>
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
                    placeholder="Enter Contact Number" value="<?php echo $this->input->cookie('contact'); ?>">
                  </div>
                  <div class="col-lg-6">
                    <label>Alternate Contact</label>
                    <input type="text" class="form-control" id="altcontact" name="altcontact"
                    placeholder="Enter Alternate Contact" value="<?php echo $this->input->cookie('altcontact'); ?>">
                  </div>
                </div>
                <div class="form-group row">
                  <div class="col-lg-12">
                    <label>Email ID</label>
                    <input type="text" class="form-control" id="email" name="email"
                    placeholder="Enter Email ID" value="<?php echo $this->input->cookie('email'); ?>">
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
                    placeholder="Enter Area Landmark" value="<?php echo $this->input->cookie('landmark'); ?>">
                  </div>
                </div>
                <div class="form-group row">
                  <div class="col-lg-12">
                    <label>Address <span style="color:red">*</span></label>
                    <textarea class="form-control" rows="5" id="address" name="address" placeholder="Enter Address" style="height:100%;"><?php echo $this->input->cookie('address'); ?></textarea>
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
                    placeholder="Enter Aadhar Number" value="<?php echo $this->input->cookie('aadhar'); ?>">
                  </div>
                </div>
                <div class="form-group row">
                  <div class="col-lg-12">
                    <label>Comment</label>
                    <textarea class="form-control" rows="5" id="comment" name="comment" placeholder="Enter Comment" style="height:100%;"><?php echo $this->input->cookie('comment'); ?></textarea>
                  </div>
                </div>
              </div>
            </div>

            <br>

            <div class="form-group row">
              <div class="col-lg-8">
                <button type="submit" class="btn btn-info offset-lg-7">Add Student</button>
                <button type="reset" class="btn btn-dark">Reset</button>
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
      if($this->input->cookie('message_code')==1){
        echo "<script>";
        echo "$(document).ready(function(){";
        echo "success('New student added','Successful');";
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
        echo "error('Student not added','Unsuccessful');";
        echo "});";
        echo "</script>";
      }

    ?>
