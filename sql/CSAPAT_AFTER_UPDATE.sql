create or replace TRIGGER CSAPAT_AFTER_UPDATE 
AFTER UPDATE ON Csapat
FOR EACH ROW
BEGIN
  INSERT INTO Logs VALUES(:new.id, 'Updated');
END;