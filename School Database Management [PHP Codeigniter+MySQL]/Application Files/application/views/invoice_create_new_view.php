<div class="row justify-content-center">
<div class="col-lg-12">
<div class="card">
    <div class="card-body">

          <!-- value="<?php echo $this->input->cookie('student_count'); ?>" -->
          <!-- This line of code will display details of students from cookie -->
          <form class="form-valide" action="<?php echo base_url(); ?>invoice/show_students" method="post">
            <div class="col-lg-12"><hr></div>
            <div class="col-lg-6">
              <div class="form-group row">
                <div class="col-lg-4">
                  <select class="form-control" id="class" name="class">
                    <option value="">Class</option>
                    <option value="First">First</option>
                    <option value="Second">Second</option>
                    <option value="Third">Third</option>
                    <option value="Forth">Forth</option>
                    <option value="Fifth">Fifth</option>
                    <option value="Sixth">Sixth</option>
                    <option value="Seventh">Seventh</option>
                    <option value="Eighth">Eighth</option>
                    <option value="Nineth">Nineth</option>
                    <option value="Tenth">Tenth</option>
                  </select>
                </div>
                <div class="col-lg-4">
                  <select class="form-control" id="division" name="division">
                    <option value="">Division</option>
                    <option value="A">A</option>
                    <option value="B">B</option>
                    <option value="C">C</option>
                    <option value="D">D</option>
                  </select>
                </div>
                <div class="col-lg-4">
                  <button type="submit" id="list" class="btn btn-info btn-flat">List Students</button>
                </div>
              </div>
          </div>
          <div class="col-lg-12"><hr></div>
          </form>
        <div class="table-responsive m-t-40">
            <table id="example11" class="display nowrap table table-hover table-striped table-bordered" cellspacing="0" width="100%">
                <thead>
                    <tr>
                        <th>GR Number</th>
                        <th>Full Name</th>
                        <th>Class</th>
                        <th>Division</th>
                    </tr>
                </thead>
                <tbody>
                  <?php

                  for ($i=0; $i<$this->input->cookie('student_count'); $i++) {
                    echo "<tr>";
                      echo "<td>";
                        echo $this->input->cookie('student_'.$i.'_0');
                      echo "</td>";
                      echo "<td>";
                        echo "<a href='".base_url()."invoice/show_fees/".
                             $this->input->cookie('student_'.$i.'_0')."/".
                             $this->input->cookie('student_'.$i.'_2')."/".
                             $this->input->cookie('student_'.$i.'_3')
                             ."' target='_blank'>";
                        echo $this->input->cookie('student_'.$i.'_1');
                        echo "</a>";
                      echo "</td>";
                      echo "<td>";
                        echo $this->input->cookie('student_'.$i.'_2');
                      echo "</td>";
                      echo "<td>";
                        echo $this->input->cookie('student_'.$i.'_3');
                      echo "</td>";
                    echo "</tr>";
                  }

                  ?>
                </tbody>
            </table>
        </div>
    </div>
</div>
</div>
</div>
