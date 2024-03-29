//import React from "react"
import ReactDOM from "react-dom/client"
import { RouterProvider } from "react-router-dom";

import { router } from "./routes/_router.tsx";

import "@mantine/core/styles.css";
import "@/styles/global.css";

ReactDOM.createRoot(document.getElementById("root")!).render(
  //<React.StrictMode>
  <RouterProvider router={router} />
  //</React.StrictMode>
)

// Remove Preload scripts loading
postMessage({ payload: 'removeLoading' }, '*')

// Use contextBridge
window.ipcRenderer.on('main-process-message', (_event, message) => {
  console.log(message)
})
