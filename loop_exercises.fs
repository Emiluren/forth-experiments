\ Solutions for Starting Forth chapter 6 exercises

42 constant starchar

: stars ( n -- )
  0 do starchar emit loop
;

: box ( width height -- )
  cr
  0 do
    dup
    stars
    cr
  loop
  drop
;

: \STARS ( height -- )
  cr
  0 do
    i spaces
    10 stars
    cr
  loop
;

: /stars ( height -- )
  1- 0 swap do
    cr
    i spaces
    10 stars
    -1
  +loop
;


