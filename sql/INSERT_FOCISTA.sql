create or replace PROCEDURE INSERT_FOCISTA
(
    p_szuletesi_ev  IN  focista.szuletesi_ev%TYPE,
    p_vezeteknev      IN  focista.vezeteknev%TYPE,
    p_keresztnev IN focista.keresztnev%TYPE
)
AUTHID DEFINER
AS 
    v_i         INT := 1;
    v_char      CHAR; 
    v_ascii     INT;
    v_cnt       INT;
    v_id        INT;
    v_rowcnt  INT;
BEGIN
  IF p_szuletesi_ev < 1930 and p_szuletesi_ev > 2003 THEN 
        RETURN;
    END IF;

    -- MINDEN KARAKTERE BETÛ-E 
WHILE v_i <= LENGTH(TRIM(p_vezeteknev)) LOOP 
    v_char := SUBSTR(p_vezeteknev, v_i, 1);
    v_i := v_i + 1;
END LOOP;
    
WHILE v_i <= LENGTH(TRIM(p_keresztnev)) LOOP 
    v_char := SUBSTR(p_keresztnev, v_i, 1);
    v_i := v_i + 1;
END LOOP;
    
v_id := GET_FOCISTA_NEXT_ID();
    
INSERT INTO focista(id, szuletesi_ev, vezeteknev, keresztnev)
VALUES (v_id, p_szuletesi_ev, p_vezeteknev, p_keresztnev);
v_rowcnt := SQL%ROWCOUNT;
END INSERT_FOCISTA;