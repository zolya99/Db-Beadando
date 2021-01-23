create or replace FUNCTION GET_POSZT_NEXT_ID 
RETURN INT 
AUTHID DEFINER
AS
    v_id poszt.id%TYPE;
BEGIN
SELECT
        NVL(MAX(id) + 1, 1)
    INTO
        v_id
    FROM poszt;
  RETURN v_id;
END GET_POSZT_NEXT_ID;