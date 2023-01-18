// This file is to test most branches in the program so I can make sure my 
// error handling is correct



         .   // Lex error
         =   // Lex error
8:           // Invalid start token

         .data
Number:  .doubleword 35, -20, 0x33AAF3154555D499
X123:    .doubleword -1, 0, 0xFF, 0Xabcdef
Number1: .doubleword 0XCAB 0xCAB // Missing comma
a9999999:.doubleword 0x1234567890abcdefg // g is not part of hex humber, viewed
                                         // as identifier, missing comma error
         .doubleword 0XCAB, 0xCAB,       // got newline instead of number
         .doubleword Cat

         .text
rTest:   ADDS   LR, IP0, IP1
         ADDS   XZR, SP, FP
         ADDR   XZR, SP, FP             // Opcode error
         ADDS   XZI, SP, FP             // Register error
         ADDS   XZR  SP, FP             // Comma error
         ADDS   XZR, SD, FP             // Register error
         ADDS   XZR, SP  FP             // Comma error
         ADDS   XZR, SP, PF             // Register error
         ADDS   XZR, SP, FP FP          // Extra stuff

iTest:   ADDI   X0, X1, #-2048          // Smallest number
         ADDIS  X0, X1, #2047           // Largest number
         ADDIS  X01, X1, #2047          // Register error
         ADDIS  X0  X1, #2047           // Comma error
         ADDIS  X0, X111, #2047         // Register error
         ADDIS  X0, X1  #2047           // Comma error 
         ADDIS  X0, X1, -2048           // Missing #
         ADDIS  X0, X1, #2048           // Too large         
         ADDIS  X0, X1, #-2049          // Too small     
         ADDIS  X0, X1, #-2049   0xff   // Extra stuff

dTest:   STUR   XZR, [FP, #-256]        // Smallest number
         LDUR   XZR, [FP, #255]         // Largest number
         LDUR   XR, [FP, #255]          // Register error
         LDUR   XZR  [FP, #255]         // Comma error
         LDUR   XZR, {FP, #255}         // Lex error, illegal char
         LDUR   XZR,  FP, #255]         // lbracket error
         LDUR   XZR, [F8P, #255]        // Register error
         LDUR   XZR, [FP  #255]         // Comma error
         LDUR   XZR, [FP, 255]          // Missing #
         LDUR   XZR, [FP, #256]         // Too large
         LDUR   XZR, [FP, #-257]        // Too small
         LDUR   XZR, [FP, #-257]]       // Extra stuff         

iwTest:  MOVZ   X9, 0xFF, LSL 0:        // Test each valid value
         MOVZ   X9, 0xFF, LSL 16:
         MOVZ   X9, 0xFF, LSL 32:
         MOVZ   X9, 0xFF, LSL 48:
         MOVK   X9, #255, LSL 0:        // Immediate or hex is fine
         MOVK   X9, #-32768, LSL 0:     // Smallest number
         MOVK   X9, #32767, LSL 0:      // Largest number
         MOVZ   X99, 0xFF, LSL 0:       // Register error
         MOVZ   X9  0xFF, LSL 0:        // Comma error
         MOVZ   X9, 255, LSL 0:         // Not immediate or hex
         MOVZ   X9, X10, LSL 0:         // Not immediate or hex
         MOVZ   X9, 0xFF  LSL 0:        // Comma error
         MOVZ   X9, 0xFF, 0xFF 0:       // Not identifier
         MOVZ   X9, 0xFF, SLS 0:        // Wrong identifier
         MOVZ   X9, 0xFF, LSL #0:       // Not decimal
         MOVZ   X9, 0xFF, LSL -18:      // Wrong decimal
         MOVZ   X9, 0xFF, LSL 42:       // Wrong decimal
         MOVZ   X9, 0xFF, LSL 0         // Missing colon
         MOVZ   X9, #-32769, LSL 0:     // Too small
         MOVZ   X9, #32768, LSL 0:      // Too large
         MOVZ   X9, 0xFF, LSL 0::       // Extra stuff

cbTest:  CBZ    XZR, Cat
         CBNZ   LR, AnotherCat 
         CBNZ   LRR, AnotherCat         // Register error
         CBNZ   LR  AnotherCat          // Comma error
         CBNZ   LR, 0xABABABABABABAB    // Not identifer
         CBNZ   LR, AnotherCat, Cat     // Extra stuff
         
bTest:   B      Cat
         B      0XFFFFFFFFFFFFFFFFFFFFFF// Not identifier
         B      :::::                   // Not identifier
         B      Cat AnotherCat          // Extra stuff
         
         .data                          // Not allowed
         .doubleword                    // Not allowed
         .doubleword 0xaabb             // Not allowed