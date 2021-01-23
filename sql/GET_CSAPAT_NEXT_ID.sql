create or replace FUNCTION GET_CSAPAT_NEXT_ID
RETURN INT
AUTHID DEFINER
AS
    v_id csapat.id%TYPE;
BEGIN
SELECT
        NVL(MAX(id) + 1, 1)
    INTO
        v_id
    FROM csapat;
  RETURN v_id;
END GET_CSAPAT_NEXT_ID;