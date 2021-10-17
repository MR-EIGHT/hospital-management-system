--SELECT * FROM Patient FOR XML PATH('Patient'), ROOT('Patients')

select * from Patient where pat_id not in (select pat_id from Diagnosis)

select * from Patient where date_discharged is null or date_discharged=''

select room_type,COUNT(*) from Room group by(room_type)

select * from patient where pat_id in(select pat_id from Diagnosis group by(pat_id) having count(*) > 1)

