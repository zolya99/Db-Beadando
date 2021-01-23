create or replace FUNCTION GET_FOCISTA_NEXT_ID
RETURN INT
AUTHID DEFINER
AS
    v_id focista.id%TYPE;
BEGIN
SELECT
        NVL(MAX(id) + 1, 1)
    INTO
        v_id
    FROM focista;
  RETURN v_id;
END GET_FOCISTA_NEXT_ID;