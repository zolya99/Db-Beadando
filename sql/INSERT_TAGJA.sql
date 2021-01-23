create or replace PROCEDURE INSERT_TAGJA
(
    p_id        IN focista.id%TYPE,
    p_id2       IN csapat.id%TYPE,
    p_mezszam   IN tagja.mezszam%TYPE
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
    FROM csapat
    WHERE id = p_id2;
    
    IF v_cnt = 0 THEN
        RETURN;
    END IF;
      
    INSERT INTO tagja(focista, csapat, mezszam)
    VALUES (p_id, p_id2, p_mezszam);

END INSERT_TAGJA;