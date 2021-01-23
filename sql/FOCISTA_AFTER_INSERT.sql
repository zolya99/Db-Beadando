create or replace TRIGGER FOCISTA_AFTER_INSERT 
After INSERT ON focista
FOR EACH ROW
BEGIN
  INSERT INTO Logs VALUES(:new.id, 'Inserted');
END;