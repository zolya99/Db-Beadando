create or replace TRIGGER CSAPAT_AFTER_INSERT 
AFTER INSERT ON Csapat
FOR EACH ROW
BEGIN
  INSERT INTO Logs VALUES(:new.id, 'Inserted');
END;