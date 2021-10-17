--create procedure Receptionists As select * from Staff where title = 'Receptionist'

--create procedure HeadNurses As select * from Staff where title = 'Head-Nurse'
--create procedure AllNurses As select * from Staff where title = 'Head-Nurse' or title = 'Nurse'
--create procedure Janitors As select * from Staff where title = 'Janitor'
--create procedure Security As select * from Staff where title = 'Security'

--create procedure Ophthalmologists As select dr_code,expert,Doctor.SID,Name,Address,tell,gender,title from Doctor, Staff where Doctor.SID=Staff.SID and expert='Ophthalmologist'
--create procedure Obstetricians As select dr_code,expert,Doctor.SID,Name,Address,tell,gender,title from Doctor, Staff where Doctor.SID=Staff.SID and expert='Obstetrician'
--create procedure Cardiologists As select dr_code,expert,Doctor.SID,Name,Address,tell,gender,title from Doctor, Staff where Doctor.SID=Staff.SID and expert='Cardiologist'
--create procedure Endocrinologists As select dr_code,expert,Doctor.SID,Name,Address,tell,gender,title from Doctor, Staff where Doctor.SID=Staff.SID and expert='Endocrinologist'
--create procedure Gastroenterologists As select dr_code,expert,Doctor.SID,Name,Address,tell,gender,title from Doctor, Staff where Doctor.SID=Staff.SID and expert='Gastroenterologist'













