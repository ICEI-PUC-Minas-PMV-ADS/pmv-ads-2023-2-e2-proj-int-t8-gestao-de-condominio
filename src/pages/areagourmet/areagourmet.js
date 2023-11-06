function Buttonvoltar() {
    window.location.href = "../telainicial/telainicial.html";
}

function desmarcar(id) {
    if (id === 'op1') {
      document.getElementById('op2').checked = false;
    } else if (id === 'op2') {
      document.getElementById('op1').checked = false;
    }
  }
  