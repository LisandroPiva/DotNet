string st1 = "ea";
string st2 = "ae";
string st3 = "valor";
string st4 = "dea";
string st = "opa";
/*
if (st1 == null) {
    if (st2 == null) {
        st = st3;
    }
    else {
        st = st2;
    }
}
else {
    st = st1;
}
if (st4 == null) {
    st4 = "valor por defecto";
}*/

st = st1 ?? st2 ?? st3;
st4 = st4 ?? "Valor por defecto";

