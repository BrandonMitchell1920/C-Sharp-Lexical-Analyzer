         .data
Number:  .doubleword
         .doubleword 2, 2
         .doubleword
        
         .text
Begin:   MOVZ   X1, #0, LSL 48: // Gibberish
         MOVZ   X2, #1, LSL 0: // Gibberish
         MOVZ   X9, 0x1000, LSL 16: // X9 holds address of static data
         LDUR   X3, [X9, #0] // X3 holds first data word
         LDUR   X2, [X9, #8] // X2 holds second data word
Loop:    ADDI   X2, X2, #-1 // Decrement 
         CBZ    X2, Save // Exit loop on 0
         ADD    X1, X1, X3 // Accumulate sum
         B      Loop
Save:    STUR   X2, [X9, #8] // Store accumulated sum