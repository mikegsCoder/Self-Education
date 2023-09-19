const bcrypt = require('bcrypt');

const saltRounds = 8;
const myPlaintextPassword = 'password1';
const someOtherPlaintextPassword = 'password2';

async function gen() {
    // const salt = await bcrypt.genSalt(saltRounds);
    // console.log(salt);
    // const hash = await bcrypt.hash(myPlaintextPassword, salt);
    // console.log(hash);

    const hash = await bcrypt.hash(myPlaintextPassword, saltRounds);
}

async function comp(hash) {
    const check1 = await bcrypt.compare(myPlaintextPassword, hash) 
    console.log('Comparing: ', myPlaintextPassword, ' -> ', check1);
    
    const check2 = await bcrypt.compare(someOtherPlaintextPassword, hash) 
    console.log('Comparing: ', someOtherPlaintextPassword, ' -> ', check2);
}

gen();

comp('$2b$10$77wdXJ8YIrES3sb.e96OpOCt7MWx4Uep5O3ZopDpPZR0wIVEDd35W');