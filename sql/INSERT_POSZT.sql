create or replace PROCEDURE INSERT_POSZT
(
    p_megnevezes       in poszt.megnevezes%TYPE,
    p_id        OUT poszt.id%TYPE
    
)
AUTHID DEFINER
AS 
    v_i         INT := 1;
    v_char      CHAR; 
    v_ascii     INT;
    v_cnt       INT;
    
BEGIN
  WHILE v_i <= LENGTH(TRIM(p_megnevezes)) LOOP 
        v_char := SUBSTR(p_megnevezes, v_i, 1);


        v_i := v_i + 1;
    END LOOP;
    
    SELECT 
        COUNT(*)
    INTO
        v_cnt
    FROM poszt
    WHERE megnevezes = p_megnevezes;
    
    IF v_cnt <> 0 THEN
        RETURN;
    END IF;
END INSERT_POSZT;