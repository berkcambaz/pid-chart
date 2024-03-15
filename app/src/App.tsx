import { MantineProvider } from "@mantine/core";
import { Outlet, ScrollRestoration } from "react-router-dom";
import { theme } from "./styles/theme";

function App() {
  return (
    <>
      <MantineProvider theme={theme} defaultColorScheme="dark">
        <Outlet />

        {/* Modals */}
      </MantineProvider>

      <ScrollRestoration />
    </>
  )
}

export default App
