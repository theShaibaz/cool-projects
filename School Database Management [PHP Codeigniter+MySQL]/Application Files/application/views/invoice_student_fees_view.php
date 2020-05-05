<!-- Start Page Content -->
<div class="row justify-content-center">
  <div class="col-lg-12">
    <div class="card">
      <div class="card-body">
        <div class="form-validation">

          <!-- value="<?php echo $this->input->cookie('grnumber'); ?>" -->
          <!-- This line of code will restore previously entered value from cookie -->
          <form class="form-valide" action="<?php echo base_url(); ?>invoice/create_new_invoice" method="post">
            <!-- <div class="form-group row"> -->
              <div class="col-lg-12">
                <h3 class="card-title m-t-15">Student</h3>
                <hr>
                <div class="form-group row">

                  <div class="col-lg-3">
                    <label>GR Number</label>
                    <input type="text" class="form-control" id="grnumber" name="grnumber"
                    placeholder="GR Number" value="<?php echo $term_one[0]['gr_number']; ?>" readonly>
                  </div>
                  <div class="col-lg-3">
                    <label>Full Name</label>
                    <input type="text" class="form-control" id="fullname" name="fullname"
                    placeholder="Full Name" value="<?php echo $name; ?>" readonly>
                  </div>
                  <div class="col-lg-3">
                    <label>Class</label>
                    <input type="text" class="form-control" id="class" name="class"
                    placeholder="Class" value="<?php echo $term_one[0]['class']; ?>" readonly>
                  </div>
                  <div class="col-lg-3">
                    <label>Division</label>
                    <input type="text" class="form-control" id="division" name="division"
                    placeholder="Division" value="<?php echo $term_one[0]['division']; ?>" readonly>
                  </div>

                </div>
              </div>

              <br>

              <div class="col-lg-12">
                <h3 class="card-title m-t-15">First Term</h3>
                <hr>

                <div class="form-group row">
                  <div class="col-lg-2">
                    <label>June</label>
                    <input type="text" class="form-control" id="june" name="june"
                    placeholder=""
                    value="<?php if($term_one[0]['june'])echo $term_one[0]['june']; ?>"
                    <?php if($term_one[0]['june'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>July</label>
                    <input type="text" class="form-control" id="july" name="july"
                    placeholder=""
                    value="<?php if($term_one[0]['july'])echo $term_one[0]['july']; ?>"
                    <?php if($term_one[0]['july'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>August</label>
                    <input type="text" class="form-control" id="august" name="august"
                    placeholder=""
                    value="<?php if($term_one[0]['august'])echo $term_one[0]['august']; ?>"
                    <?php if($term_one[0]['august'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>September</label>
                    <input type="text" class="form-control" id="september" name="september"
                    placeholder=""
                    value="<?php if($term_one[0]['september'])echo $term_one[0]['september']; ?>"
                    <?php if($term_one[0]['september'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>October</label>
                    <input type="text" class="form-control" id="october" name="october"
                    placeholder=""
                    value="<?php if($term_one[0]['october'])echo $term_one[0]['october']; ?>"
                    <?php if($term_one[0]['october'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>November</label>
                    <input type="text" class="form-control" id="november" name="november"
                    placeholder=""
                    value="<?php if($term_one[0]['november'])echo $term_one[0]['november']; ?>"
                    <?php if($term_one[0]['november'])echo "disabled"; ?>>
                  </div>
                </div>

                <div class="form-group row">
                  <div class="col-lg-2">
                    <label>Term</label>
                    <input type="text" class="form-control" id="term_one" name="term_one"
                    placeholder=""
                    value="<?php if($term_one[0]['term'])echo $term_one[0]['term']; ?>"
                    <?php if($term_one[0]['term'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>Activity</label>
                    <input type="text" class="form-control" id="activity_one" name="activity_one"
                    placeholder=""
                    value="<?php if($term_one[0]['activity'])echo $term_one[0]['activity']; ?>"
                    <?php if($term_one[0]['activity'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>Computer</label>
                    <input type="text" class="form-control" id="computer_one" name="computer_one"
                    placeholder=""
                    value="<?php if($term_one[0]['computer'])echo $term_one[0]['computer']; ?>"
                    <?php if($term_one[0]['computer'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>Elearning</label>
                    <input type="text" class="form-control" id="elearning_one" name="elearning_one"
                    placeholder=""
                    value="<?php if($term_one[0]['elearning'])echo $term_one[0]['elearning']; ?>"
                    <?php if($term_one[0]['elearning'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>Sport</label>
                    <input type="text" class="form-control" id="sport_one" name="sport_one"
                    placeholder=""
                    value="<?php if($term_one[0]['sport'])echo $term_one[0]['sport']; ?>"
                    <?php if($term_one[0]['sport'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>Total</label>
                    <input type="text" class="form-control" id="total_one" name="total_one"
                    placeholder="" style="background-color:lightblue;font-weight:bold;"
                    value="<?php if($term_one[0]['total'])echo $term_one[0]['total']; ?>" readonly>
                  </div>
                </div>
              </div>


              <div class="col-lg-12">
                <h3 class="card-title m-t-15">Second Term</h3>
                <hr>

                <div class="form-group row">
                  <div class="col-lg-2">
                    <label>December</label>
                    <input type="text" class="form-control" id="december" name="december"
                    placeholder=""
                    value="<?php if($term_two[0]['december'])echo $term_two[0]['december']; ?>"
                    <?php if($term_two[0]['december'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>January</label>
                    <input type="text" class="form-control" id="january" name="january"
                    placeholder=""
                    value="<?php if($term_two[0]['january'])echo $term_two[0]['january']; ?>"
                    <?php if($term_two[0]['january'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>February</label>
                    <input type="text" class="form-control" id="february" name="february"
                    placeholder=""
                    value="<?php if($term_two[0]['february'])echo $term_two[0]['february']; ?>"
                    <?php if($term_two[0]['february'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>March</label>
                    <input type="text" class="form-control" id="march" name="march"
                    placeholder=""
                    value="<?php if($term_two[0]['march'])echo $term_two[0]['march']; ?>"
                    <?php if($term_two[0]['march'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>April</label>
                    <input type="text" class="form-control" id="april" name="april"
                    placeholder=""
                    value="<?php if($term_two[0]['april'])echo $term_two[0]['april']; ?>"
                    <?php if($term_two[0]['april'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>May</label>
                    <input type="text" class="form-control" id="may" name="may"
                    placeholder=""
                    value="<?php if($term_two[0]['may'])echo $term_two[0]['may']; ?>"
                    <?php if($term_two[0]['may'])echo "disabled"; ?>>
                  </div>
                </div>

                <div class="form-group row">
                  <div class="col-lg-2">
                    <label>Term</label>
                    <input type="text" class="form-control" id="term_two" name="term_two"
                    placeholder=""
                    value="<?php if($term_two[0]['term'])echo $term_two[0]['term']; ?>"
                    <?php if($term_two[0]['term'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>Activity</label>
                    <input type="text" class="form-control" id="activity_two" name="activity_two"
                    placeholder=""
                    value="<?php if($term_two[0]['activity'])echo $term_two[0]['activity']; ?>"
                    <?php if($term_two[0]['activity'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>Computer</label>
                    <input type="text" class="form-control" id="computer_two" name="computer_two"
                    placeholder=""
                    value="<?php if($term_two[0]['computer'])echo $term_two[0]['computer']; ?>"
                    <?php if($term_two[0]['computer'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>Elearning</label>
                    <input type="text" class="form-control" id="elearning_two" name="elearning_two"
                    placeholder=""
                    value="<?php if($term_two[0]['elearning'])echo $term_two[0]['elearning']; ?>"
                    <?php if($term_two[0]['elearning'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>Sport</label>
                    <input type="text" class="form-control" id="sport_two" name="sport_two"
                    placeholder=""
                    value="<?php if($term_two[0]['sport'])echo $term_two[0]['sport']; ?>"
                    <?php if($term_two[0]['sport'])echo "disabled"; ?>>
                  </div>
                  <div class="col-lg-2">
                    <label>Total</label>
                    <input type="text" class="form-control" id="total_two" name="total_two"
                    placeholder="" style="background-color:lightblue;font-weight:bold;"
                    value="<?php if($term_two[0]['total'])echo $term_two[0]['total']; ?>" readonly>
                  </div>
                </div>
              </div>

            <br>

            <div class="col-lg-12">
              <h3 class="card-title m-t-15">Miscellaneous</h3>
              <hr>

              <div class="form-group row">
                <div class="col-lg-6">
                  <label>Fees Help</label>
                  <input type="text" class="form-control" id="fees_help" name="fees_help"
                  placeholder="Enter Fees Help">
                </div>
                <div class="col-lg-6">
                  <label>Comment</label>
                  <input type="text" class="form-control" id="comment" name="comment"
                  placeholder="Enter Comment">
                </div>
              </div>
            </div>

            <br>

            <div class="form-group row">
              <div class="col-lg-8">
                <button type="submit" class="btn btn-info btn-flat offset-lg-6">Create Invoice</button>
                <button type="reset" class="btn btn-dark btn-flat ">Reset</button>
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
        echo "success('Invoice created','Successful');";
        echo "});";
        echo "</script>";
      }
      if($this->input->cookie('message_code')==3){
        echo "<script>";
        echo "$(document).ready(function(){";
        echo "warning('Entered at least one fees amount','Check Input');";
        echo "});";
        echo "</script>";
      }
      if($this->input->cookie('message_code')==3){
        echo "<script>";
        echo "$(document).ready(function(){";
        echo "error(Invoice not created','Unsuccessful');";
        echo "});";
        echo "</script>";
      }

    ?>
