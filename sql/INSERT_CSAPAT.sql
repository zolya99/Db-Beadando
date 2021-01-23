create or replace PROCEDURE INSERT_CSAPAT
(
    p_nev       in csapat.nev%TYPE
    
)
AUTHID DEFINER
AS 
    v_i         INT := 1;
    v_char      CHAR; 
    v_ascii     INT;
    v_cnt       INT;
    v_id        INT;
    v_rowcnt    INT;
BEGIN
  WHILE v_i <= LENGTH(TRIM(p_nev)) LOOP 
        v_char := SUBSTR(p_nev, v_i, 1);


        v_i := v_i + 1;
    END LOOP;
    
    SELECT 
        COUNT(*)
    INTO
        v_cnt
    FROM csapat
    WHERE nev = p_nev;
    
    IF v_cnt <> 0 THEN
        RETURN;
    END IF;
    
    v_id := GET_CSAPAT_NEXT_ID();
    
    INSERT INTO csapat(id, nev)
    VALUES (v_id, p_nev);
    
    /* Implicit kurzorattribútum segístségével le tudom kérdezni az éri ntett sorok számát*/
    /* Fontos az, hogy az attribútum értékének kiolvasása közvetlen kövesse a végrehajtását*/
    v_rowcnt := SQL%ROWCOUNT;
END INSERT_CSAPAT;