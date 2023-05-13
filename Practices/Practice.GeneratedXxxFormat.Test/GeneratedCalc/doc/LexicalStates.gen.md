-------------------------------
# 1/5: extracted ε-NFA
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
eNFA0_0_64636290[["εNFA0-0 wholeStart"]]
eNFA1_2_8097541[["εNFA1-2 regex start"]]
class eNFA1_2_8097541 c1000;
eNFA2_2_44855704[["εNFA2-2 regex start"]]
class eNFA2_2_44855704 c1000;
eNFA3_2_31719739[["εNFA3-2 regex start"]]
class eNFA3_2_31719739 c1000;
eNFA4_2_27365507[["εNFA4-2 regex start"]]
class eNFA4_2_27365507 c1000;
eNFA5_2_57656175[["εNFA5-2 regex start"]]
class eNFA5_2_57656175 c1000;
eNFA6_2_21913016[["εNFA6-2 regex start"]]
class eNFA6_2_21913016 c1000;
eNFA7_2_6883221[["εNFA7-2 regex start"]]
class eNFA7_2_6883221 c1000;
eNFA1_0_27440617[["εNFA1-0 scope{1, ∞}"]]
eNFA2_0_17792110[["εNFA2-0 char{1, 1}"]]
eNFA3_0_19162058[["εNFA3-0 char{1, 1}"]]
eNFA4_0_2013564[["εNFA4-0 char{1, 1}"]]
eNFA5_0_39638585[["εNFA5-0 char{1, 1}"]]
eNFA6_0_30123835[["εNFA6-0 char{1, 1}"]]
eNFA7_0_20670010[["εNFA7-0 char{1, 1}"]]
eNFA1_1_3048957[["εNFA1-1 scope[1]"]]
eNFA2_1_25911262[["εNFA2-1 char[1]"]]
eNFA3_1_38240801[["εNFA3-1 char[1]"]]
eNFA4_1_18122076[["εNFA4-1 char[1]"]]
eNFA5_1_21202951[["εNFA5-1 char[1]"]]
eNFA6_1_2679067[["εNFA6-1 char[1]"]]
eNFA7_1_51812368[["εNFA7-1 char[1]"]]
eNFA1_3_45638969[["εNFA1-3 regex end"]]
class eNFA1_3_45638969 c0100;
eNFA2_3_31874772[["εNFA2-3 regex end"]]
class eNFA2_3_31874772 c0100;
eNFA3_3_8622890[["εNFA3-3 regex end"]]
class eNFA3_3_8622890 c0100;
eNFA4_3_28880957[["εNFA4-3 regex end"]]
class eNFA4_3_28880957 c0100;
eNFA5_3_56608836[["εNFA5-3 regex end"]]
class eNFA5_3_56608836 c0100;
eNFA6_3_24111608[["εNFA6-3 regex end"]]
class eNFA6_3_24111608 c0100;
eNFA7_3_63658128[["εNFA7-3 regex end"]]
class eNFA7_3_63658128 c0100;
eNFA1_4_5769005[["εNFA1-4 post-regex start"]]
class eNFA1_4_5769005 c0010;
eNFA2_4_18437496[["εNFA2-4 post-regex start"]]
class eNFA2_4_18437496 c0010;
eNFA3_4_10497152[["εNFA3-4 post-regex start"]]
class eNFA3_4_10497152 c0010;
eNFA4_4_58602024[["εNFA4-4 post-regex start"]]
class eNFA4_4_58602024 c0010;
eNFA5_4_39717481[["εNFA5-4 post-regex start"]]
class eNFA5_4_39717481 c0010;
eNFA6_4_15677883[["εNFA6-4 post-regex start"]]
class eNFA6_4_15677883 c0010;
eNFA7_4_36052245[["εNFA7-4 post-regex start"]]
class eNFA7_4_36052245 c0010;
eNFA1_5_51921052[\"εNFA1-5 post-regex end"/]
class eNFA1_5_51921052 c0001;
eNFA2_5_1048160[\"εNFA2-5 post-regex end"/]
class eNFA2_5_1048160 c0001;
eNFA3_5_17042198[\"εNFA3-5 post-regex end"/]
class eNFA3_5_17042198 c0001;
eNFA4_5_44962972[\"εNFA4-5 post-regex end"/]
class eNFA4_5_44962972 c0001;
eNFA5_5_49143529[\"εNFA5-5 post-regex end"/]
class eNFA5_5_49143529 c0001;
eNFA6_5_62999416[\"εNFA6-5 post-regex end"/]
class eNFA6_5_62999416 c0001;
eNFA7_5_61948991[\"εNFA7-5 post-regex end"/]
class eNFA7_5_61948991 c0001;
eNFA0_1_9433441[\"εNFA0-1 wholeEnd"/]
eNFA0_0_64636290 -.->|"ε"|eNFA1_2_8097541
eNFA0_0_64636290 -.->|"ε"|eNFA2_2_44855704
eNFA0_0_64636290 -.->|"ε"|eNFA3_2_31719739
eNFA0_0_64636290 -.->|"ε"|eNFA4_2_27365507
eNFA0_0_64636290 -.->|"ε"|eNFA5_2_57656175
eNFA0_0_64636290 -.->|"ε"|eNFA6_2_21913016
eNFA0_0_64636290 -.->|"ε"|eNFA7_2_6883221
eNFA1_2_8097541 -.->|"ε
BeginToken 'number'"|eNFA1_0_27440617
eNFA2_2_44855704 -.->|"ε
BeginToken '+'"|eNFA2_0_17792110
eNFA3_2_31719739 -.->|"ε
BeginToken '-'"|eNFA3_0_19162058
eNFA4_2_27365507 -.->|"ε
BeginToken '*'"|eNFA4_0_2013564
eNFA5_2_57656175 -.->|"ε
BeginToken '/'"|eNFA5_0_39638585
eNFA6_2_21913016 -.->|"ε
BeginToken '('"|eNFA6_0_30123835
eNFA7_2_6883221 -.->|"ε
BeginToken ')'"|eNFA7_0_20670010
eNFA1_0_27440617 -->|"[0-9]"|eNFA1_1_3048957
eNFA2_0_17792110 -->|"+"|eNFA2_1_25911262
eNFA3_0_19162058 -->|"-"|eNFA3_1_38240801
eNFA4_0_2013564 -->|"*"|eNFA4_1_18122076
eNFA5_0_39638585 -->|"/"|eNFA5_1_21202951
eNFA6_0_30123835 -->|"("|eNFA6_1_2679067
eNFA7_0_20670010 -->|")"|eNFA7_1_51812368
eNFA1_1_3048957 -->|"[0-9]"|eNFA1_1_3048957
eNFA1_1_3048957 -.->|"ε
ExtendToken 'number'"|eNFA1_3_45638969
eNFA2_1_25911262 -.->|"ε
ExtendToken '+'"|eNFA2_3_31874772
eNFA3_1_38240801 -.->|"ε
ExtendToken '-'"|eNFA3_3_8622890
eNFA4_1_18122076 -.->|"ε
ExtendToken '*'"|eNFA4_3_28880957
eNFA5_1_21202951 -.->|"ε
ExtendToken '/'"|eNFA5_3_56608836
eNFA6_1_2679067 -.->|"ε
ExtendToken '('"|eNFA6_3_24111608
eNFA7_1_51812368 -.->|"ε
ExtendToken ')'"|eNFA7_3_63658128
eNFA1_3_45638969 -.->|"ε"|eNFA1_4_5769005
eNFA2_3_31874772 -.->|"ε"|eNFA2_4_18437496
eNFA3_3_8622890 -.->|"ε"|eNFA3_4_10497152
eNFA4_3_28880957 -.->|"ε"|eNFA4_4_58602024
eNFA5_3_56608836 -.->|"ε"|eNFA5_4_39717481
eNFA6_3_24111608 -.->|"ε"|eNFA6_4_15677883
eNFA7_3_63658128 -.->|"ε"|eNFA7_4_36052245
eNFA1_4_5769005 -.->|"ε
CheckToken 'number'
AcceptToken 'number'"|eNFA1_5_51921052
eNFA2_4_18437496 -.->|"ε
CheckToken '+'
AcceptToken '+'"|eNFA2_5_1048160
eNFA3_4_10497152 -.->|"ε
CheckToken '-'
AcceptToken '-'"|eNFA3_5_17042198
eNFA4_4_58602024 -.->|"ε
CheckToken '*'
AcceptToken '*'"|eNFA4_5_44962972
eNFA5_4_39717481 -.->|"ε
CheckToken '/'
AcceptToken '/'"|eNFA5_5_49143529
eNFA6_4_15677883 -.->|"ε
CheckToken '('
AcceptToken '('"|eNFA6_5_62999416
eNFA7_4_36052245 -.->|"ε
CheckToken ')'
AcceptToken ')'"|eNFA7_5_61948991
eNFA1_5_51921052 -.->|"ε"|eNFA0_1_9433441
eNFA2_5_1048160 -.->|"ε"|eNFA0_1_9433441
eNFA3_5_17042198 -.->|"ε"|eNFA0_1_9433441
eNFA4_5_44962972 -.->|"ε"|eNFA0_1_9433441
eNFA5_5_49143529 -.->|"ε"|eNFA0_1_9433441
eNFA6_5_62999416 -.->|"ε"|eNFA0_1_9433441
eNFA7_5_61948991 -.->|"ε"|eNFA0_1_9433441
```
-------------------------------
# 2/5: manifested ε-NFA
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
eNFA0_0_56034750[["εNFA0-0 wholeStart"]]
class eNFA0_0_56034750 c1000;
eNFA1_2_42520941[["εNFA1-2 regex start"]]
class eNFA1_2_42520941 c1000;
eNFA2_2_34550710[["εNFA2-2 regex start"]]
class eNFA2_2_34550710 c1000;
eNFA3_2_47144157[["εNFA3-2 regex start"]]
class eNFA3_2_47144157 c1000;
eNFA4_2_21644229[["εNFA4-2 regex start"]]
class eNFA4_2_21644229 c1000;
eNFA5_2_60580335[["εNFA5-2 regex start"]]
class eNFA5_2_60580335 c1000;
eNFA6_2_8352109[["εNFA6-2 regex start"]]
class eNFA6_2_8352109 c1000;
eNFA7_2_8060118[["εNFA7-2 regex start"]]
class eNFA7_2_8060118 c1000;
eNFA1_0_48889850[["εNFA1-0 scope{1, ∞}"]]
class eNFA1_0_48889850 c1000;
eNFA2_0_16639474[["εNFA2-0 char{1, 1}"]]
class eNFA2_0_16639474 c1000;
eNFA3_0_52579650[["εNFA3-0 char{1, 1}"]]
class eNFA3_0_52579650 c1000;
eNFA4_0_35528341[["εNFA4-0 char{1, 1}"]]
class eNFA4_0_35528341 c1000;
eNFA5_0_32361769[["εNFA5-0 char{1, 1}"]]
class eNFA5_0_32361769 c1000;
eNFA6_0_60232767[["εNFA6-0 char{1, 1}"]]
class eNFA6_0_60232767 c1000;
eNFA7_0_50198296[["εNFA7-0 char{1, 1}"]]
class eNFA7_0_50198296 c1000;
eNFA1_1_5432205[\"εNFA1-1 scope[1]
AcceptToken 'number'"/]
class eNFA1_1_5432205 c0111;
eNFA2_1_15537542[\"εNFA2-1 char[1]
AcceptToken '+'"/]
class eNFA2_1_15537542 c0111;
eNFA3_1_3454809[\"εNFA3-1 char[1]
AcceptToken '-'"/]
class eNFA3_1_3454809 c0111;
eNFA4_1_51319614[\"εNFA4-1 char[1]
AcceptToken '*'"/]
class eNFA4_1_51319614 c0111;
eNFA5_1_22820469[\"εNFA5-1 char[1]
AcceptToken '/'"/]
class eNFA5_1_22820469 c0111;
eNFA6_1_5223998[\"εNFA6-1 char[1]
AcceptToken '('"/]
class eNFA6_1_5223998 c0111;
eNFA7_1_49131481[\"εNFA7-1 char[1]
AcceptToken ')'"/]
class eNFA7_1_49131481 c0111;
eNFA1_3_37355470[\"εNFA1-3 regex end
AcceptToken 'number'"/]
class eNFA1_3_37355470 c0111;
eNFA1_4_31674992[\"εNFA1-4 post-regex start
AcceptToken 'number'"/]
class eNFA1_4_31674992 c0011;
eNFA1_5_53048087[\"εNFA1-5 post-regex end"/]
class eNFA1_5_53048087 c0011;
eNFA0_1_5894231[\"εNFA0-1 wholeEnd"/]
eNFA2_3_5620158[\"εNFA2-3 regex end
AcceptToken '+'"/]
class eNFA2_3_5620158 c0111;
eNFA2_4_50581426[\"εNFA2-4 post-regex start
AcceptToken '+'"/]
class eNFA2_4_50581426 c0011;
eNFA2_5_654914[\"εNFA2-5 post-regex end"/]
class eNFA2_5_654914 c0011;
eNFA3_3_31093287[\"εNFA3-3 regex end
AcceptToken '-'"/]
class eNFA3_3_31093287 c0111;
eNFA3_4_11404133[\"εNFA3-4 post-regex start
AcceptToken '-'"/]
class eNFA3_4_11404133 c0011;
eNFA3_5_7670737[\"εNFA3-5 post-regex end"/]
class eNFA3_5_7670737 c0011;
eNFA4_3_59223347[\"εNFA4-3 regex end
AcceptToken '*'"/]
class eNFA4_3_59223347 c0111;
eNFA4_4_63248075[\"εNFA4-4 post-regex start
AcceptToken '*'"/]
class eNFA4_4_63248075 c0011;
eNFA4_5_1927776[\"εNFA4-5 post-regex end"/]
class eNFA4_5_1927776 c0011;
eNFA5_3_4057632[\"εNFA5-3 regex end
AcceptToken '/'"/]
class eNFA5_3_4057632 c0111;
eNFA5_4_36518691[\"εNFA5-4 post-regex start
AcceptToken '/'"/]
class eNFA5_4_36518691 c0011;
eNFA5_5_17349988[\"εNFA5-5 post-regex end"/]
class eNFA5_5_17349988 c0011;
eNFA6_3_47015983[\"εNFA6-3 regex end
AcceptToken '('"/]
class eNFA6_3_47015983 c0111;
eNFA6_4_20490669[\"εNFA6-4 post-regex start
AcceptToken '('"/]
class eNFA6_4_20490669 c0011;
eNFA6_5_21932166[\"εNFA6-5 post-regex end"/]
class eNFA6_5_21932166 c0011;
eNFA7_3_39530145[\"εNFA7-3 regex end
AcceptToken ')'"/]
class eNFA7_3_39530145 c0111;
eNFA7_4_20226985[\"εNFA7-4 post-regex start
AcceptToken ')'"/]
class eNFA7_4_20226985 c0011;
eNFA7_5_63171767[\"εNFA7-5 post-regex end"/]
class eNFA7_5_63171767 c0011;
eNFA0_0_56034750 -.->|"ε"|eNFA1_2_42520941
eNFA0_0_56034750 -.->|"ε"|eNFA2_2_34550710
eNFA0_0_56034750 -.->|"ε"|eNFA3_2_47144157
eNFA0_0_56034750 -.->|"ε"|eNFA4_2_21644229
eNFA0_0_56034750 -.->|"ε"|eNFA5_2_60580335
eNFA0_0_56034750 -.->|"ε"|eNFA6_2_8352109
eNFA0_0_56034750 -.->|"ε"|eNFA7_2_8060118
eNFA0_0_56034750 -.->|"ε
BeginToken 'number'"|eNFA1_0_48889850
eNFA0_0_56034750 -.->|"ε
BeginToken '+'"|eNFA2_0_16639474
eNFA0_0_56034750 -.->|"ε
BeginToken '-'"|eNFA3_0_52579650
eNFA0_0_56034750 -.->|"ε
BeginToken '*'"|eNFA4_0_35528341
eNFA0_0_56034750 -.->|"ε
BeginToken '/'"|eNFA5_0_32361769
eNFA0_0_56034750 -.->|"ε
BeginToken '('"|eNFA6_0_60232767
eNFA0_0_56034750 -.->|"ε
BeginToken ')'"|eNFA7_0_50198296
eNFA0_0_56034750 -->|"[0-9]
BeginToken 'number'
ExtendToken 'number'"|eNFA1_1_5432205
eNFA0_0_56034750 -->|"+
BeginToken '+'
ExtendToken '+'"|eNFA2_1_15537542
eNFA0_0_56034750 -->|"-
BeginToken '-'
ExtendToken '-'"|eNFA3_1_3454809
eNFA0_0_56034750 -->|"*
BeginToken '*'
ExtendToken '*'"|eNFA4_1_51319614
eNFA0_0_56034750 -->|"/
BeginToken '/'
ExtendToken '/'"|eNFA5_1_22820469
eNFA0_0_56034750 -->|"(
BeginToken '('
ExtendToken '('"|eNFA6_1_5223998
eNFA0_0_56034750 -->|")
BeginToken ')'
ExtendToken ')'"|eNFA7_1_49131481
eNFA1_2_42520941 -.->|"ε
BeginToken 'number'"|eNFA1_0_48889850
eNFA1_2_42520941 -->|"[0-9]
BeginToken 'number'
ExtendToken 'number'"|eNFA1_1_5432205
eNFA2_2_34550710 -.->|"ε
BeginToken '+'"|eNFA2_0_16639474
eNFA2_2_34550710 -->|"+
BeginToken '+'
ExtendToken '+'"|eNFA2_1_15537542
eNFA3_2_47144157 -.->|"ε
BeginToken '-'"|eNFA3_0_52579650
eNFA3_2_47144157 -->|"-
BeginToken '-'
ExtendToken '-'"|eNFA3_1_3454809
eNFA4_2_21644229 -.->|"ε
BeginToken '*'"|eNFA4_0_35528341
eNFA4_2_21644229 -->|"*
BeginToken '*'
ExtendToken '*'"|eNFA4_1_51319614
eNFA5_2_60580335 -.->|"ε
BeginToken '/'"|eNFA5_0_32361769
eNFA5_2_60580335 -->|"/
BeginToken '/'
ExtendToken '/'"|eNFA5_1_22820469
eNFA6_2_8352109 -.->|"ε
BeginToken '('"|eNFA6_0_60232767
eNFA6_2_8352109 -->|"(
BeginToken '('
ExtendToken '('"|eNFA6_1_5223998
eNFA7_2_8060118 -.->|"ε
BeginToken ')'"|eNFA7_0_50198296
eNFA7_2_8060118 -->|")
BeginToken ')'
ExtendToken ')'"|eNFA7_1_49131481
eNFA1_0_48889850 -->|"[0-9]
BeginToken 'number'
ExtendToken 'number'"|eNFA1_1_5432205
eNFA2_0_16639474 -->|"+
BeginToken '+'
ExtendToken '+'"|eNFA2_1_15537542
eNFA3_0_52579650 -->|"-
BeginToken '-'
ExtendToken '-'"|eNFA3_1_3454809
eNFA4_0_35528341 -->|"*
BeginToken '*'
ExtendToken '*'"|eNFA4_1_51319614
eNFA5_0_32361769 -->|"/
BeginToken '/'
ExtendToken '/'"|eNFA5_1_22820469
eNFA6_0_60232767 -->|"(
BeginToken '('
ExtendToken '('"|eNFA6_1_5223998
eNFA7_0_50198296 -->|")
BeginToken ')'
ExtendToken ')'"|eNFA7_1_49131481
eNFA1_1_5432205 -->|"[0-9]
ExtendToken 'number'"|eNFA1_1_5432205
eNFA1_1_5432205 -.->|"ε
ExtendToken 'number'"|eNFA1_3_37355470
eNFA1_1_5432205 -.->|"ε"|eNFA1_4_31674992
eNFA1_1_5432205 -.->|"ε
CheckToken 'number'
AcceptToken 'number'"|eNFA1_5_53048087
eNFA1_1_5432205 -.->|"ε
CheckToken 'number'"|eNFA0_1_5894231
eNFA2_1_15537542 -.->|"ε
ExtendToken '+'"|eNFA2_3_5620158
eNFA2_1_15537542 -.->|"ε"|eNFA2_4_50581426
eNFA2_1_15537542 -.->|"ε
CheckToken '+'
AcceptToken '+'"|eNFA2_5_654914
eNFA2_1_15537542 -.->|"ε
CheckToken '+'"|eNFA0_1_5894231
eNFA3_1_3454809 -.->|"ε
ExtendToken '-'"|eNFA3_3_31093287
eNFA3_1_3454809 -.->|"ε"|eNFA3_4_11404133
eNFA3_1_3454809 -.->|"ε
CheckToken '-'
AcceptToken '-'"|eNFA3_5_7670737
eNFA3_1_3454809 -.->|"ε
CheckToken '-'"|eNFA0_1_5894231
eNFA4_1_51319614 -.->|"ε
ExtendToken '*'"|eNFA4_3_59223347
eNFA4_1_51319614 -.->|"ε"|eNFA4_4_63248075
eNFA4_1_51319614 -.->|"ε
CheckToken '*'
AcceptToken '*'"|eNFA4_5_1927776
eNFA4_1_51319614 -.->|"ε
CheckToken '*'"|eNFA0_1_5894231
eNFA5_1_22820469 -.->|"ε
ExtendToken '/'"|eNFA5_3_4057632
eNFA5_1_22820469 -.->|"ε"|eNFA5_4_36518691
eNFA5_1_22820469 -.->|"ε
CheckToken '/'
AcceptToken '/'"|eNFA5_5_17349988
eNFA5_1_22820469 -.->|"ε
CheckToken '/'"|eNFA0_1_5894231
eNFA6_1_5223998 -.->|"ε
ExtendToken '('"|eNFA6_3_47015983
eNFA6_1_5223998 -.->|"ε"|eNFA6_4_20490669
eNFA6_1_5223998 -.->|"ε
CheckToken '('
AcceptToken '('"|eNFA6_5_21932166
eNFA6_1_5223998 -.->|"ε
CheckToken '('"|eNFA0_1_5894231
eNFA7_1_49131481 -.->|"ε
ExtendToken ')'"|eNFA7_3_39530145
eNFA7_1_49131481 -.->|"ε"|eNFA7_4_20226985
eNFA7_1_49131481 -.->|"ε
CheckToken ')'
AcceptToken ')'"|eNFA7_5_63171767
eNFA7_1_49131481 -.->|"ε
CheckToken ')'"|eNFA0_1_5894231
eNFA1_3_37355470 -.->|"ε"|eNFA1_4_31674992
eNFA1_3_37355470 -.->|"ε
CheckToken 'number'
AcceptToken 'number'"|eNFA1_5_53048087
eNFA1_3_37355470 -.->|"ε
CheckToken 'number'"|eNFA0_1_5894231
eNFA1_4_31674992 -.->|"ε
CheckToken 'number'
AcceptToken 'number'"|eNFA1_5_53048087
eNFA1_4_31674992 -.->|"ε
CheckToken 'number'"|eNFA0_1_5894231
eNFA1_5_53048087 -.->|"ε
CheckToken 'number'"|eNFA0_1_5894231
eNFA2_3_5620158 -.->|"ε"|eNFA2_4_50581426
eNFA2_3_5620158 -.->|"ε
CheckToken '+'
AcceptToken '+'"|eNFA2_5_654914
eNFA2_3_5620158 -.->|"ε
CheckToken '+'"|eNFA0_1_5894231
eNFA2_4_50581426 -.->|"ε
CheckToken '+'
AcceptToken '+'"|eNFA2_5_654914
eNFA2_4_50581426 -.->|"ε
CheckToken '+'"|eNFA0_1_5894231
eNFA2_5_654914 -.->|"ε
CheckToken '+'"|eNFA0_1_5894231
eNFA3_3_31093287 -.->|"ε"|eNFA3_4_11404133
eNFA3_3_31093287 -.->|"ε
CheckToken '-'
AcceptToken '-'"|eNFA3_5_7670737
eNFA3_3_31093287 -.->|"ε
CheckToken '-'"|eNFA0_1_5894231
eNFA3_4_11404133 -.->|"ε
CheckToken '-'
AcceptToken '-'"|eNFA3_5_7670737
eNFA3_4_11404133 -.->|"ε
CheckToken '-'"|eNFA0_1_5894231
eNFA3_5_7670737 -.->|"ε
CheckToken '-'"|eNFA0_1_5894231
eNFA4_3_59223347 -.->|"ε"|eNFA4_4_63248075
eNFA4_3_59223347 -.->|"ε
CheckToken '*'
AcceptToken '*'"|eNFA4_5_1927776
eNFA4_3_59223347 -.->|"ε
CheckToken '*'"|eNFA0_1_5894231
eNFA4_4_63248075 -.->|"ε
CheckToken '*'
AcceptToken '*'"|eNFA4_5_1927776
eNFA4_4_63248075 -.->|"ε
CheckToken '*'"|eNFA0_1_5894231
eNFA4_5_1927776 -.->|"ε
CheckToken '*'"|eNFA0_1_5894231
eNFA5_3_4057632 -.->|"ε"|eNFA5_4_36518691
eNFA5_3_4057632 -.->|"ε
CheckToken '/'
AcceptToken '/'"|eNFA5_5_17349988
eNFA5_3_4057632 -.->|"ε
CheckToken '/'"|eNFA0_1_5894231
eNFA5_4_36518691 -.->|"ε
CheckToken '/'
AcceptToken '/'"|eNFA5_5_17349988
eNFA5_4_36518691 -.->|"ε
CheckToken '/'"|eNFA0_1_5894231
eNFA5_5_17349988 -.->|"ε
CheckToken '/'"|eNFA0_1_5894231
eNFA6_3_47015983 -.->|"ε"|eNFA6_4_20490669
eNFA6_3_47015983 -.->|"ε
CheckToken '('
AcceptToken '('"|eNFA6_5_21932166
eNFA6_3_47015983 -.->|"ε
CheckToken '('"|eNFA0_1_5894231
eNFA6_4_20490669 -.->|"ε
CheckToken '('
AcceptToken '('"|eNFA6_5_21932166
eNFA6_4_20490669 -.->|"ε
CheckToken '('"|eNFA0_1_5894231
eNFA6_5_21932166 -.->|"ε
CheckToken '('"|eNFA0_1_5894231
eNFA7_3_39530145 -.->|"ε"|eNFA7_4_20226985
eNFA7_3_39530145 -.->|"ε
CheckToken ')'
AcceptToken ')'"|eNFA7_5_63171767
eNFA7_3_39530145 -.->|"ε
CheckToken ')'"|eNFA0_1_5894231
eNFA7_4_20226985 -.->|"ε
CheckToken ')'
AcceptToken ')'"|eNFA7_5_63171767
eNFA7_4_20226985 -.->|"ε
CheckToken ')'"|eNFA0_1_5894231
eNFA7_5_63171767 -.->|"ε
CheckToken ')'"|eNFA0_1_5894231
```
-------------------------------
# 3/5: NFA
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
NFA0_0_27773061("NFA0-0 wholeStart")
class NFA0_0_27773061 c1000;
NFA1_1_47825138[\"NFA1-1 scope[1]
AcceptToken 'number'"/]
class NFA1_1_47825138 c0101;
NFA2_1_48630964[\"NFA2-1 char[1]
AcceptToken '+'"/]
class NFA2_1_48630964 c0101;
NFA3_1_35025494[\"NFA3-1 char[1]
AcceptToken '-'"/]
class NFA3_1_35025494 c0101;
NFA4_1_46793998[\"NFA4-1 char[1]
AcceptToken '*'"/]
class NFA4_1_46793998 c0101;
NFA5_1_18492804[\"NFA5-1 char[1]
AcceptToken '/'"/]
class NFA5_1_18492804 c0101;
NFA6_1_32217513[\"NFA6-1 char[1]
AcceptToken '('"/]
class NFA6_1_32217513 c0101;
NFA7_1_21522166[\"NFA7-1 char[1]
AcceptToken ')'"/]
class NFA7_1_21522166 c0101;
NFA0_0_27773061 -->|"[0-9]
BeginToken 'number'
ExtendToken 'number'"|NFA1_1_47825138
NFA0_0_27773061 -->|"+
BeginToken '+'
ExtendToken '+'"|NFA2_1_48630964
NFA0_0_27773061 -->|"-
BeginToken '-'
ExtendToken '-'"|NFA3_1_35025494
NFA0_0_27773061 -->|"*
BeginToken '*'
ExtendToken '*'"|NFA4_1_46793998
NFA0_0_27773061 -->|"/
BeginToken '/'
ExtendToken '/'"|NFA5_1_18492804
NFA0_0_27773061 -->|"(
BeginToken '('
ExtendToken '('"|NFA6_1_32217513
NFA0_0_27773061 -->|")
BeginToken ')'
ExtendToken ')'"|NFA7_1_21522166
NFA1_1_47825138 -->|"[0-9]
ExtendToken 'number'"|NFA1_1_47825138
```
-------------------------------
# 4/5: DFA
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
subgraph DFA0_1371898302["DFA0 wholeStart"]
NFA0_0_27773061_0("NFA0-0 wholeStart")
class NFA0_0_27773061_0 c1000;
end
class DFA0_1371898302 c1000;
subgraph DFA1_736285203["DFA1 {1}"]
NFA1_1_47825138_1[\"NFA1-1 scope[1]
AcceptToken 'number'"/]
class NFA1_1_47825138_1 c0101;
end
class DFA1_736285203 c0101;
subgraph DFA2_24116860["DFA2 {1}"]
NFA2_1_48630964_2[\"NFA2-1 char[1]
AcceptToken '+'"/]
class NFA2_1_48630964_2 c0101;
end
class DFA2_24116860 c0101;
subgraph DFA3_1215392932["DFA3 {1}"]
NFA3_1_35025494_3[\"NFA3-1 char[1]
AcceptToken '-'"/]
class NFA3_1_35025494_3 c0101;
end
class DFA3_1215392932 c0101;
subgraph DFA4_-740876899["DFA4 {1}"]
NFA4_1_46793998_4[\"NFA4-1 char[1]
AcceptToken '*'"/]
class NFA4_1_46793998_4 c0101;
end
class DFA4_-740876899 c0101;
subgraph DFA5_-2132989191["DFA5 {1}"]
NFA5_1_18492804_5[\"NFA5-1 char[1]
AcceptToken '/'"/]
class NFA5_1_18492804_5 c0101;
end
class DFA5_-2132989191 c0101;
subgraph DFA6_-489194620["DFA6 {1}"]
NFA6_1_32217513_6[\"NFA6-1 char[1]
AcceptToken '('"/]
class NFA6_1_32217513_6 c0101;
end
class DFA6_-489194620 c0101;
subgraph DFA7_431494236["DFA7 {1}"]
NFA7_1_21522166_7[\"NFA7-1 char[1]
AcceptToken ')'"/]
class NFA7_1_21522166_7 c0101;
end
class DFA7_431494236 c0101;
DFA0_1371898302 -->|"[0-9]
BeginToken 'number'
ExtendToken 'number'"|DFA1_736285203
DFA0_1371898302 -->|"+
BeginToken '+'
ExtendToken '+'"|DFA2_24116860
DFA0_1371898302 -->|"-
BeginToken '-'
ExtendToken '-'"|DFA3_1215392932
DFA0_1371898302 -->|"*
BeginToken '*'
ExtendToken '*'"|DFA4_-740876899
DFA0_1371898302 -->|"/
BeginToken '/'
ExtendToken '/'"|DFA5_-2132989191
DFA0_1371898302 -->|"(
BeginToken '('
ExtendToken '('"|DFA6_-489194620
DFA0_1371898302 -->|")
BeginToken ')'
ExtendToken ')'"|DFA7_431494236
DFA1_736285203 -->|"[0-9]
ExtendToken 'number'"|DFA1_736285203
```
-------------------------------
# 4/5: DFA.simple
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
DFA0_1371898302{{"DFA0 wholeStart"}}
class DFA0_1371898302 c1000;
DFA1_736285203[\"DFA1 {1}
AcceptToken 'number'"/]
class DFA1_736285203 c0101;
DFA2_24116860[\"DFA2 {1}
AcceptToken '+'"/]
class DFA2_24116860 c0101;
DFA3_1215392932[\"DFA3 {1}
AcceptToken '-'"/]
class DFA3_1215392932 c0101;
DFA4_-740876899[\"DFA4 {1}
AcceptToken '*'"/]
class DFA4_-740876899 c0101;
DFA5_-2132989191[\"DFA5 {1}
AcceptToken '/'"/]
class DFA5_-2132989191 c0101;
DFA6_-489194620[\"DFA6 {1}
AcceptToken '('"/]
class DFA6_-489194620 c0101;
DFA7_431494236[\"DFA7 {1}
AcceptToken ')'"/]
class DFA7_431494236 c0101;
DFA0_1371898302 -->|"[0-9]
BeginToken 'number'
ExtendToken 'number'"|DFA1_736285203
DFA0_1371898302 -->|"+
BeginToken '+'
ExtendToken '+'"|DFA2_24116860
DFA0_1371898302 -->|"-
BeginToken '-'
ExtendToken '-'"|DFA3_1215392932
DFA0_1371898302 -->|"*
BeginToken '*'
ExtendToken '*'"|DFA4_-740876899
DFA0_1371898302 -->|"/
BeginToken '/'
ExtendToken '/'"|DFA5_-2132989191
DFA0_1371898302 -->|"(
BeginToken '('
ExtendToken '('"|DFA6_-489194620
DFA0_1371898302 -->|")
BeginToken ')'
ExtendToken ')'"|DFA7_431494236
DFA1_736285203 -->|"[0-9]
ExtendToken 'number'"|DFA1_736285203
```
-------------------------------
# 5/5: miniDFA
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
subgraph MiniDFA0_-1091152074["MiniDFA0 {1}"]
DFA0_1371898302_0{{"DFA0 wholeStart"}}
class DFA0_1371898302_0 c1000;
end
class MiniDFA0_-1091152074 c1000;
subgraph MiniDFA1_-535935755["MiniDFA1 {1}"]
DFA1_736285203_1[\"DFA1 {1}
AcceptToken 'number'"/]
class DFA1_736285203_1 c0101;
end
class MiniDFA1_-535935755 c0101;
subgraph MiniDFA2_1414120990["MiniDFA2 {1}"]
DFA2_24116860_2[\"DFA2 {1}
AcceptToken '+'"/]
class DFA2_24116860_2 c0101;
end
class MiniDFA2_1414120990 c0101;
subgraph MiniDFA3_43568831["MiniDFA3 {1}"]
DFA3_1215392932_3[\"DFA3 {1}
AcceptToken '-'"/]
class DFA3_1215392932_3 c0101;
end
class MiniDFA3_43568831 c0101;
subgraph MiniDFA4_1354508476["MiniDFA4 {1}"]
DFA4_-740876899_4[\"DFA4 {1}
AcceptToken '*'"/]
class DFA4_-740876899_4 c0101;
end
class MiniDFA4_1354508476 c0101;
subgraph MiniDFA5_1421150537["MiniDFA5 {1}"]
DFA5_-2132989191_5[\"DFA5 {1}
AcceptToken '/'"/]
class DFA5_-2132989191_5 c0101;
end
class MiniDFA5_1421150537 c0101;
subgraph MiniDFA6_481334329["MiniDFA6 {1}"]
DFA6_-489194620_6[\"DFA6 {1}
AcceptToken '('"/]
class DFA6_-489194620_6 c0101;
end
class MiniDFA6_481334329 c0101;
subgraph MiniDFA7_1635294136["MiniDFA7 {1}"]
DFA7_431494236_7[\"DFA7 {1}
AcceptToken ')'"/]
class DFA7_431494236_7 c0101;
end
class MiniDFA7_1635294136 c0101;
MiniDFA0_-1091152074 -->|"[0-9]
BeginToken 'number'
ExtendToken 'number'"|MiniDFA1_-535935755
MiniDFA0_-1091152074 -->|"+
BeginToken '+'
ExtendToken '+'"|MiniDFA2_1414120990
MiniDFA0_-1091152074 -->|"-
BeginToken '-'
ExtendToken '-'"|MiniDFA3_43568831
MiniDFA0_-1091152074 -->|"*
BeginToken '*'
ExtendToken '*'"|MiniDFA4_1354508476
MiniDFA0_-1091152074 -->|"/
BeginToken '/'
ExtendToken '/'"|MiniDFA5_1421150537
MiniDFA0_-1091152074 -->|"(
BeginToken '('
ExtendToken '('"|MiniDFA6_481334329
MiniDFA0_-1091152074 -->|")
BeginToken ')'
ExtendToken ')'"|MiniDFA7_1635294136
MiniDFA1_-535935755 -->|"[0-9]
ExtendToken 'number'"|MiniDFA1_-535935755
```
-------------------------------
# 5/5: miniDFA.simple
```Mermaid
flowchart
classDef c0001 color:#FF0000;
classDef c0010 stroke-dasharray: 10 10;
classDef c0011 stroke-dasharray: 10 10,color:#FF0000;
classDef c0100 fill:#BB66EE;
classDef c0101 fill:#BB66EE,color:#FF0000;
classDef c0110 fill:#BB66EE,stroke-dasharray: 10 10;
classDef c0111 fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
classDef c1000 stroke:#333,stroke-width:4px;
classDef c1001 stroke:#333,stroke-width:4px,color:#FF0000;
classDef c1010 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10;
classDef c1011 stroke:#333,stroke-width:4px,stroke-dasharray: 10 10,color:#FF0000;
classDef c1100 stroke:#333,stroke-width:4px,fill:#BB66EE;
classDef c1101 stroke:#333,stroke-width:4px,fill:#BB66EE,color:#FF0000;
classDef c1110 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10;
classDef c1111 stroke:#333,stroke-width:4px,fill:#BB66EE,stroke-dasharray: 10 10,color:#FF0000;
MiniDFA0_-1091152074(["MiniDFA0 {1}"])
class MiniDFA0_-1091152074 c1000;
MiniDFA1_-535935755[\"MiniDFA1 {1}
AcceptToken 'number'"/]
class MiniDFA1_-535935755 c0101;
MiniDFA2_1414120990[\"MiniDFA2 {1}
AcceptToken '+'"/]
class MiniDFA2_1414120990 c0101;
MiniDFA3_43568831[\"MiniDFA3 {1}
AcceptToken '-'"/]
class MiniDFA3_43568831 c0101;
MiniDFA4_1354508476[\"MiniDFA4 {1}
AcceptToken '*'"/]
class MiniDFA4_1354508476 c0101;
MiniDFA5_1421150537[\"MiniDFA5 {1}
AcceptToken '/'"/]
class MiniDFA5_1421150537 c0101;
MiniDFA6_481334329[\"MiniDFA6 {1}
AcceptToken '('"/]
class MiniDFA6_481334329 c0101;
MiniDFA7_1635294136[\"MiniDFA7 {1}
AcceptToken ')'"/]
class MiniDFA7_1635294136 c0101;
MiniDFA0_-1091152074 -->|"[0-9]
BeginToken 'number'
ExtendToken 'number'"|MiniDFA1_-535935755
MiniDFA0_-1091152074 -->|"+
BeginToken '+'
ExtendToken '+'"|MiniDFA2_1414120990
MiniDFA0_-1091152074 -->|"-
BeginToken '-'
ExtendToken '-'"|MiniDFA3_43568831
MiniDFA0_-1091152074 -->|"*
BeginToken '*'
ExtendToken '*'"|MiniDFA4_1354508476
MiniDFA0_-1091152074 -->|"/
BeginToken '/'
ExtendToken '/'"|MiniDFA5_1421150537
MiniDFA0_-1091152074 -->|"(
BeginToken '('
ExtendToken '('"|MiniDFA6_481334329
MiniDFA0_-1091152074 -->|")
BeginToken ')'
ExtendToken ')'"|MiniDFA7_1635294136
MiniDFA1_-535935755 -->|"[0-9]
ExtendToken 'number'"|MiniDFA1_-535935755
```
-------------------------------
