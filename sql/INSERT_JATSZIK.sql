create or replace PROCEDURE INSERT_JATSZIK
(
    p_id        IN focista.id%TYPE,
    p_id2       IN poszt.id%TYPE
)
AUTHID DEFINER
AS 
    v_i         INT := 1;
    v_char      CHAR; 
    v_ascii     INT;
    v_cnt       INT;

BEGIN
    SELECT 
        COUNT(*)
    INTO
        v_cnt
    FROM focista
    WHERE id = p_id;
    
    IF v_cnt = 0 THEN
        RETURN;
    END IF;
    
    SELECT 
        COUNT(*)
    INTO
        v_cnt
    FROM poszt
    WHERE id = p_id2;
    
    IF v_cnt = 0 THEN
        RETURN;
    END IF;
    
    INSERT INTO jatszik(focista, poszt)
    VALUES (p_id, p_id2);

END INSERT_JATSZIK;