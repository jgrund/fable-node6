module rec Node.Globals

open Node.Buffer
open Node.Base
open Fable.Core

let [<Global>] ``global``: NodeJS.Global = jsNative
let [<Global>] __filename: string = jsNative
let [<Global>] __dirname: string = jsNative
let [<Global>] require: NodeJS.NodeRequire = jsNative
let [<Global>] ``module``: NodeJS.NodeModule = jsNative
let [<Global>] exports: obj = jsNative
let [<Global>] SlowBuffer: buffer_types.SlowBufferStatic = jsNative
let [<Global>] Buffer: buffer_types.BufferStatic = jsNative
